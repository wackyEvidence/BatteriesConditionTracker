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

        public BatteryModelForm()
        {
            InitializeComponent();
        }


        // Возможное решение: 
        // Сделать класс Validator, который будет содержать в себе логику проверки различных типов полей. У каждой формы реализовать метод
        // ValidateForm(), который будет вызывать соответствующие методы класса Validator. Метод ValidateForm создаст словарь вида
        // [Имя поля] - [Текст ошибки]. Если в конце всех проверок длина словаря будет >0, он отправляется классу  ValidationErrorsDisplayer,
        // который умеет выводить ошибки на экран. 

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

                foreach (var connection in GlobalConfig.Connections)
                {
                    connection.CreateBatteryModel(batteryModel);
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            GetBatteryModelSizes(out string length, out string width , out string height);  

            FieldValidator.ValidateStringEmptiness(errors, nameValue.Text, nameLabel.Text);
            FieldValidator.ValidateStringEmptiness(errors, brandValue.Text, brandLabel.Text);
            FieldValidator.ValidatePositiveDoubleParameter(errors, capacityValue.Text, capacityLabel.Text);
            FieldValidator.ValidatePositiveDoubleParameter(errors, voltageValue.Text, voltageLabel.Text);
            FieldValidator.ValidatePositiveIntParameter(errors, costValue.Text, costLabel.Text);
            FieldValidator.ValidatePositiveDoubleParameter(errors, bufferServiceTimeValue.Text, bufferServiceTimeLabel.Text);
            FieldValidator.ValidatePositiveIntParameter(errors, minSoHValue.Text, minSoHLabel.Text);
            FieldValidator.ValidatePositiveIntParameter(errors, length, "Длина");
            FieldValidator.ValidatePositiveIntParameter(errors, width, "Ширина");
            FieldValidator.ValidatePositiveIntParameter(errors, height, "Высота");
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
