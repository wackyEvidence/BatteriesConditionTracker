using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Validation
{
    public interface IValidatable
    {
        /// <summary>
        /// Осуществляет проверку правильности заполнения полей формы.
        /// </summary>
        /// <returns>Список вида [Имя поля]-[Текст ошибки]</returns>
        Dictionary<string, string> ValidateForm(); 
    }
}
