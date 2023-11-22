using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatteryExploitationStatus : IHaveId
    {
        /// <summary>
        /// Id статуса эксплуатации аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус эксплуатации аккумулятора
        /// </summary>
        public string Name { get; set; }

        public static readonly Func<string[], BatteryExploitationStatus> ModelCreation = columns => new BatteryExploitationStatus(columns);

        public BatteryExploitationStatus() { }
        public BatteryExploitationStatus(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
        }
    }

    public class BatteryReplacementStatus : IHaveId
    {
        /// <summary>
        /// Id статуса замены аккумулятора 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус замены аккумулятора 
        /// </summary>
        public string Name { get; set; }

        public static readonly Func<string[], BatteryReplacementStatus> ModelCreation = columns => new BatteryReplacementStatus(columns);


        public BatteryReplacementStatus() { }

        public BatteryReplacementStatus(string id, string name) 
        {
            Id = int.Parse(id);
            Name = name; 
        }
        public BatteryReplacementStatus(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }
}
