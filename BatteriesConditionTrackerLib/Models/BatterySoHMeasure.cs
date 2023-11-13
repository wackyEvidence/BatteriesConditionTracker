using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BatteriesConditionTrackerLib.Models
{
    public class BatterySoHMeasure : IHaveId
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
        /// Сотрудник, измеряющий SoH
        /// </summary>
        public User PerformingEmployee { get; set; }
        /// <summary>
        /// Дата проведения измерения
        /// </summary>
        public DateTime MeasureDate { get; set; }
        /// <summary>
        /// Измеренное значение SoH
        /// </summary>
        public double SoHValue { get; set; }

        public BatterySoHMeasure() { }

        public BatterySoHMeasure(string id, string battery, string employee, string measureDate, string soh)
        {
            // TO DO - Написать конструктор с получением экземпляров классов ConcreteBattery и User по Id 
        }

        public BatterySoHMeasure(string[] columns)
        {
            // TO DO - Разобраться с СoncreteBattery и PerformingEmployee
            Id = int.Parse(columns[0]);
            var batteryId = int.Parse(columns[1]);
            var performingEmployeeId = int.Parse(columns[2]); 
            MeasureDate = DateTime.Parse(columns[3]);
            SoHValue = double.Parse(columns[4]); 
        }
    }
}
