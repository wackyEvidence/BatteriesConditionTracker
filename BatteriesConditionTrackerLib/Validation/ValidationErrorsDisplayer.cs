using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerLib.Validation
{
    public static class ValidationErrorsDisplayer
    {
        /// <summary>
        /// Отображает в MessageBox список ошибок при заполнении формы. 
        /// </summary>
        /// <param name="errorMessages">Словарь вида [Имя поля]-[Текст ошибки]</param>
        public static void DisplayErrors(Dictionary<string, string> errorMessages)
        {
            var message = new StringBuilder("При заполнении формы выявлены следующие ошибки, пожалуйста, исправьте их: \n\n");

            var errorNumber = 1; 
            foreach (var error in errorMessages)
                message.AppendLine($"{errorNumber}. " + error.Value.ToString());

            MessageBox.Show(message.ToString(), "Ошибки при заполнении формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
