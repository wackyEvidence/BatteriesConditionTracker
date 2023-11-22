using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

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

        public static readonly Func<string[], BatterySoHMeasure> ModelCreation = columns => new BatterySoHMeasure(columns);
        public static readonly Func<BatterySoHMeasure, string> ModelToCSV = soh => $"{soh.Id},{soh.Battery.Id},{soh.PerformingEmployee.Id},{soh.MeasureDate},{soh.SoHValue}";

        public BatterySoHMeasure() { }

        public BatterySoHMeasure(string id, ConcreteBattery battery, User performingEmployee, string measureDate, string soh)
        {
            Id = int.Parse(id); 
            Battery = battery;
            PerformingEmployee = performingEmployee;
            MeasureDate = DateTime.Parse(measureDate);
            SoHValue = int.Parse(soh);
        }

        public BatterySoHMeasure(string[] columns)
        {
            Id = int.Parse(columns[0]);
            var batteryId = int.Parse(columns[1]);
            var performingEmployeeId = int.Parse(columns[2]); 
            MeasureDate = DateTime.Parse(columns[3]);
            SoHValue = double.Parse(columns[4]); 
        }
    }
}
