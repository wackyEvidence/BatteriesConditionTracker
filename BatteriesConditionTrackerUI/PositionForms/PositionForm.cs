using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.Validation;
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
        private Position? oldPositionModel; 

        public PositionForm(FormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            headerLabel.Text = "Добавление должности"; 
        }

        public PositionForm(FormMode mode, Position positionModel)
        {
            InitializeComponent();
            this.mode = mode;
            oldPositionModel = positionModel;
            headerLabel.Text = "Изменение должности"; 
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

            if(errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var positionModel = new Position() { Name = positionNameValue.Text };

                    GlobalConfig.Connection.CreatePosition(positionModel); 
                }
                else
                {
                    var positionModel = new Position() { Id = oldPositionModel.Id, Name = positionNameValue.Text };
                    GlobalConfig.Connection.UpdatePosition(positionModel);
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
