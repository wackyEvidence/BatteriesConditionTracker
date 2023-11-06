using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Validation
{
    /// <summary>
    /// Отвечает за проверку правильности ввода различных типов полей.
    /// </summary>
    public static class FieldValidator
    {
        /// <summary>
        /// Проверяет правильность ввода обязательного текстового поля. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameterValue">Значение проверяемого параметра</param>
        /// <param name="parameterLabel">Название проверяемого параметра</param>
        public static void ValidateStringEmptiness(Dictionary<string, string> errors, string parameterLabel, string parameterValue)
        {
            if (parameterValue.Length == 0)
                errors.Add(parameterLabel, $"Поле \"{parameterLabel}\" не заполнено.");
        }
        /// <summary>
        /// Проверяет правильность ввода списка обязательных текстовых полей. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameters">Список проверяемых параметров</param>
        public static void ValidateStringEmptiness(Dictionary<string, string> errors, List<Parameter> parameters)
        {
            foreach (var parameter in parameters)
            {
                if (parameter.Value.Length == 0)
                    errors.Add(parameter.Name, $"Поле \"{parameter.Name}\" не заполнено.");
            }
        }

        /// <summary>
        /// Проверяет правильность ввода положительного целого числа. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameterValue">Значение проверяемого параметра</param>
        /// <param name="parameterLabel">Название проверяемого параметра</param>
        public static void ValidatePositiveIntParameter(Dictionary<string, string> errors, string parameterLabel, string parameterValue)
        {
            ValidateStringEmptiness(errors, parameterValue, parameterLabel);
            // случай пустого поля 
            if (errors.ContainsKey(parameterLabel))
                return;

            if (!int.TryParse(parameterValue, out int parsedParameter))
                errors.Add(parameterLabel, $"Неверное значение поля \"{parameterLabel}\". Должно быть целым положительным числом.");
            else
            {
                if (parsedParameter <= 0)
                    errors.Add(parameterLabel, $"Неверное значение поля \"{parameterLabel}\", должно быть больше 0.");

                if (parsedParameter % 1 != 0)
                    errors.Add(parameterLabel, $"Неверное значение поля \"{parameterLabel}\", должно быть целым числом."); 
            }
        }
        /// <summary>
        /// Проверяет правильность ввода списка положительных целых чисел. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameters">Список проверяемых параметров</param>
        public static void ValidatePositiveIntParameter(Dictionary<string, string> errors, List<Parameter> parameters)
        {
            ValidateStringEmptiness(errors, parameters);

            foreach(var parameter in parameters)
            {
                // случай пустого поля 
                if (errors.ContainsKey(parameter.Name))
                    continue;

                if (!int.TryParse(parameter.Value, out int parsedParameter))
                    errors.Add(parameter.Name, $"Неверное значение поля \"{parameter.Name}\". Должно быть целым положительным числом.");
                else
                {
                    if (parsedParameter <= 0)
                        errors.Add(parameter.Name, $"Неверное значение поля \"{parameter.Name}\", должно быть больше 0.");

                    if (parsedParameter % 1 != 0)
                        errors.Add(parameter.Name, $"Неверное значение поля \"{parameter.Name}\", должно быть целым числом.");
                }
            }
        }
        /// <summary>
        /// Проверяет правильность ввода положительного числа с плавающей точкой. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameterValue">Значение проверяемого параметра</param>
        /// <param name="parameterLabel">Название проверяемого параметра</param>
        public static void ValidatePositiveDoubleParameter(Dictionary<string, string> errors, string parameterLabel,string parameterValue)
        {
            ValidateStringEmptiness(errors, parameterValue, parameterLabel);
            // случай пустого поля 
            if (errors.ContainsKey(parameterLabel))
                return;

            if (!double.TryParse(parameterValue, out double parsedParameter))
                errors.Add(parameterLabel, $"Неверное значение поля \"{parameterLabel}\", должно быть положительным числом."); 
            else
                if (parsedParameter <= 0)
                    errors.Add(parameterLabel, $"Неверное значение поля \"{parameterLabel}\", оно должно быть больше 0."); 
        }
        /// <summary>
        /// Проверяет правильность ввода списка положительных чисел с плавающей точкой. При неправильном вводе добавляет в словарь текст сообщения об ошибке.
        /// </summary>
        /// <param name="errors">Словарь вида [Имя поля]-[Текст ошибки]</param>
        /// <param name="parameters">Список проверяемых параметров</param>
        public static void ValidatePositiveDoubleParameter(Dictionary<string, string> errors, List<Parameter> parameters)
        {
            ValidateStringEmptiness(errors, parameters);
          
            foreach (var parameter in parameters)
            {
                // случай пустого поля 
                if (errors.ContainsKey(parameter.Name)) 
                    continue;

                if (!double.TryParse(parameter.Value, out double parsedParameter))
                    errors.Add(parameter.Name, $"Неверное значение поля \"{parameter.Name}\", должно быть положительным числом.");
                else
                    if (parsedParameter <= 0)
                        errors.Add(parameter.Name, $"Неверное значение поля \"{parameter.Name}\", оно должно быть больше 0.");
            }
        }
    }
}
