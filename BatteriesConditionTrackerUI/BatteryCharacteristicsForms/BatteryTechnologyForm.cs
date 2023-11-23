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
    public partial class BatteryTechnologyForm : Form, IValidatable
    {
        private FormMode mode;
        private BatteryTechnology? inputedBatteryTechnologyModel;
        private IRequester<BatteryTechnology> callingForm;

        public BatteryTechnologyForm(FormMode mode, IRequester<BatteryTechnology> caller, BatteryTechnology? batteryTechnologyModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            inputedBatteryTechnologyModel = batteryTechnologyModel;
            callingForm = caller;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление технологии" : "Изменение технологии";
            technologyNameValue.Text = mode == FormMode.Adding ? "" : batteryTechnologyModel.Name;
        }

        #region IValidatable 
        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, technologyNameLabel.Text, technologyNameValue.Text);
            return errors;
        }
        #endregion

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var batteryTechnologyModel = new BatteryTechnology() { Name = technologyNameValue.Text };

                    GlobalConfig.Connection.CreateBatteryTechnology(batteryTechnologyModel);
                    callingForm.ModelCreated(batteryTechnologyModel);
                    Close();
                }
                else
                {
                    inputedBatteryTechnologyModel.Name = technologyNameValue.Text;
                    GlobalConfig.Connection.UpdateBatteryTechnology(inputedBatteryTechnologyModel);
                    callingForm.ModelUpdated(inputedBatteryTechnologyModel);
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
