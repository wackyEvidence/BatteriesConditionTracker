using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    public class BatterySubsystem
    {
        /// <summary>
        /// Id подсистемы
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование подсистемы
        /// </summary>
        public string Name { get; set; }
    }

    public class BatteryClampType
    {
        /// <summary>
        /// Id типа клемм
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование типа клемм
        /// </summary>
        public string Name { get; set; }
    }

    public class BatteryTechnology
    {
        /// <summary>
        /// Id технологии аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование технологии аккумулятора
        /// </summary>
        public string Name { get; set; }
    }
}
