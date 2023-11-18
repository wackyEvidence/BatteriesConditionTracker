using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess
{
    // Методы для получения модели (моделей) по Id. Используются в конструкторах, при заполнении dataGridView, опций в comboBox
    // Варианты реализации
    // 1. Добавить в IDataConnection, в каждом из Connector'ов реализовать еще миллиард методов. 
    // 2. Сделать в IDataConnection поле ILookupData DataLookuper, реализовать SQLDataLookuper, PostgreDataLookuper, TextDataLookuper
    // 3. Посмотреть, как сделает Tim Corey 
    public interface IGetData
    {
        public List<BatteryExploitationStatus> GetBatteryExploitationStatus_All();
        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All();
    }
}
