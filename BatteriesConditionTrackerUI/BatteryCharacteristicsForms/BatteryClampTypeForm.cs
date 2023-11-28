using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
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
    public partial class BatteryClampTypeForm : Form, IValidatable
    {
        private FormMode mode;
        private IModelRequester<BatteryClampType> callingForm;
        private BatteryClampType? inputedClampTypeModel;

        public BatteryClampTypeForm(FormMode mode, IModelRequester<BatteryClampType> caller, BatteryClampType? clampTypeModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedClampTypeModel = clampTypeModel;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление типа клемм" : "Редактирование типа клемм";
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, clampTypeNameLabel.Text, clampTypeNameValue.Text);
            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var batteryClampTypeModel = new BatteryClampType() { Name = clampTypeNameValue.Text };

                    GlobalConfig.Connection.CreateBatteryClampType(batteryClampTypeModel);
                    callingForm.ModelCreated(batteryClampTypeModel);
                    Close();
                }
                else
                {
                    inputedClampTypeModel.Name = clampTypeNameValue.Text;
                    GlobalConfig.Connection.UpdateBatteryClampType(inputedClampTypeModel);
                    callingForm.ModelUpdated(inputedClampTypeModel);
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
