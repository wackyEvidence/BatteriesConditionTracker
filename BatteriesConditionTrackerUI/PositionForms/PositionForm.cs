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
    public partial class PositionForm : Form, IValidatable
    {
        private FormMode mode;
        private Position? inputedPositionModel;
        private IRequester<Position> callingForm;

        public PositionForm(FormMode mode, IRequester<Position> caller, Position? positionModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            inputedPositionModel = positionModel;
            callingForm = caller;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление должности" : "Изменение должности";
            positionNameValue.Text = mode == FormMode.Adding ? "" : positionModel.Name;
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, positionNameLabel.Text, positionNameValue.Text);
            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var positionModel = new Position() { Name = positionNameValue.Text };

                    GlobalConfig.Connection.CreatePosition(positionModel);
                    callingForm.ModelCreated(positionModel);
                    Close();
                }
                else
                {
                    inputedPositionModel.Name = positionNameValue.Text;
                    GlobalConfig.Connection.UpdatePosition(inputedPositionModel);
                    callingForm.ModelUpdated(inputedPositionModel);
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
