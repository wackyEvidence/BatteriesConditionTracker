using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    public class BatteryCapacityMeasure
    {
        /// <summary>
        /// Id замера емкости
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Аккумулятор, емкость которого измеряется
        /// </summary>
        public ConcreteBattery Battery { get; set; }
        /// <summary>
        /// Сотрудник, измеряющий емкость
        /// </summary>
        public User ConductingWorker { get; set; }
        /// <summary>
        /// Измеренное значение емкости
        /// </summary>
        public double CapacityValue { get; set; }
        /// <summary>
        /// Дата проведения измерения
        /// </summary>
        public DateTime MeasurmentDate { get; set; }
    }
}
