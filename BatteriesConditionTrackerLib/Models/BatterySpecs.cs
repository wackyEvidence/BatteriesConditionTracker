using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatterySubsystem : IHaveId
    {
        /// <summary>
        /// Id подсистемы
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование подсистемы
        /// </summary>
        public string Name { get; set; }

        public static readonly Func<string[], BatterySubsystem> ModelCreation = columns => new BatterySubsystem(columns);
        public static readonly Func<BatterySubsystem, string> ModelToCSV = subsystem => ($"{subsystem.Id},{subsystem.Name}");


        public BatterySubsystem() { }

        public BatterySubsystem(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class BatteryClampType : IHaveId
    {
        /// <summary>
        /// Id типа клемм
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование типа клемм
        /// </summary>
        public string Name { get; set; }

        public static readonly Func<string[], BatteryClampType> ModelCreation = columns => new BatteryClampType(columns);
        public static readonly Func<BatteryClampType, string> ModelToCSV = clampType => ($"{clampType.Id},{clampType.Name}");

        public BatteryClampType() { }

        public BatteryClampType(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }

    public class BatteryTechnology : IHaveId
    {
        /// <summary>
        /// Id технологии аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование технологии аккумулятора
        /// </summary>
        public string Name { get; set; }

        public static readonly Func<string[], BatteryTechnology> ModelCreation = columns => new BatteryTechnology(columns);
        public static readonly Func<BatteryTechnology, string> ModelToCSV = technology => ($"{technology.Id},{technology.Name}");

        public BatteryTechnology() { }

        public BatteryTechnology(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
        }
    }
}
