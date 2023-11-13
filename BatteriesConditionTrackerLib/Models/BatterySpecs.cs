using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public BatterySubsystem() { }

        public BatterySubsystem(string id, string name)
        {
            Id = int.Parse(id); 
            Name = name;
        }

        public BatterySubsystem(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
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

        public BatteryClampType() { }

        public BatteryClampType(string id, string name)
        {
            Id = int.Parse(id); 
            Name = name;
        }

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

        public BatteryTechnology() { }

        public BatteryTechnology(string id, string name)
        {
            Id = int.Parse(id);
            Name = name;
        }

        public BatteryTechnology(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
        }
    }
}
