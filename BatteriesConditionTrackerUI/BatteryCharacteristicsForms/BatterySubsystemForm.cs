using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Validation;
using BatteriesConditionTrackerUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerUI
{
    public partial class BatterySubsystemForm : Form, IValidatable
    {
        private FormMode mode;
        private BatterySubsystem? inputedBatterySubsystemModel;
        private IModelRequester<BatterySubsystem> callingForm;

        public BatterySubsystemForm(FormMode mode, IModelRequester<BatterySubsystem> caller, BatterySubsystem? batterySubsystemModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedBatterySubsystemModel = batterySubsystemModel;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление подсистемы" : "Изменение подсистемы";
            subsystemNameValue.Text = mode == FormMode.Adding ? string.Empty: batterySubsystemModel.Name;
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, subsystemNameLabel.Text, subsystemNameValue.Text);
            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var batterySubsystemModel = new BatterySubsystem() { Name = subsystemNameValue.Text };

                    GlobalConfig.Connection.CreateBatterySubsystem(batterySubsystemModel);
                    callingForm.ModelCreated(batterySubsystemModel);
                    Close();
                }
                else
                {
                    inputedBatterySubsystemModel.Name = subsystemNameValue.Text;
                    GlobalConfig.Connection.UpdateBatterySubsystem(inputedBatterySubsystemModel);
                    callingForm.ModelUpdated(inputedBatterySubsystemModel);
                    Close();
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
