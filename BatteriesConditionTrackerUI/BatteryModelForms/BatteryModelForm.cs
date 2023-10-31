using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryModelForm : Form, IValidatable
    {
        private List<string> photosList = new List<string>();
        private FormMode mode; 

        public BatteryModelForm(FormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();
            if (errors.Count == 0) // ввод верен 
            {
                GetBatteryModelSizes(out string length, out string width, out string height);

                var batteryModel = new BatteryModel(
                nameValue.Text,
                brandValue.Text,
                capacityValue.Text,
                voltageValue.Text,
                length,
                height,
                width,
                technologyComboBox.ValueMember,
                clampTypeComboBox.ValueMember,
                costValue.Text,
                bufferServiceTimeValue.Text,
                minSoHValue.Text,
                photosList
                );
                
                if(mode == FormMode.Adding)
                    foreach (var connection in GlobalConfig.Connections)
                        connection.CreateBatteryModel(batteryModel);
                    // TODO - дописать обработку случая изменения аккумулятора
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            GetBatteryModelSizes(out string length, out string width , out string height);

            var stringParams = new List<Parameter> 
            { 
                new Parameter(nameLabel.Text, nameValue.Text), 
                new Parameter(brandLabel.Text, brandValue.Text) 
            };
            var intParams = new List<Parameter>
            {
                new Parameter(length, "Длина"),
                new Parameter(width, "Ширина"),
                new Parameter(height, "Высота"),
                new Parameter(costLabel.Text, costValue.Text), 
                new Parameter(minSoHLabel.Text, minSoHValue.Text)
            };
            var doubleParams = new List<Parameter>
            {
                new Parameter(capacityLabel.Text, capacityValue.Text),
                new Parameter(voltageLabel.Text, voltageValue.Text), 
                new Parameter(bufferServiceTimeLabel.Text, bufferServiceTimeValue.Text)
            };

            FieldValidator.ValidateStringEmptiness(errors, stringParams);
            FieldValidator.ValidatePositiveIntParameter(errors, intParams);
            FieldValidator.ValidatePositiveDoubleParameter(errors, doubleParams);

            return errors;
        }

        /// <summary>
        /// Парсит данные о размерах аккумулятора из маски ввода.
        /// </summary>
        /// <param name="length">Длина аккумулятора</param>
        /// <param name="width">Ширина аккумулятора</param>
        /// <param name="height">Высота аккумулятора</param>
        private void GetBatteryModelSizes(out string length, out string width, out string height)
        {
            var sizes = sizesMaskedTextBox.Text.Split('x');
            length = sizes[0];
            width = sizes[1];
            height = sizes[2];
        }
    }
}
