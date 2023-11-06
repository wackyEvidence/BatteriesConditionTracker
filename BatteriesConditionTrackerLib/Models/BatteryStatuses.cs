using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatteryExploitationStatus
    {
        /// <summary>
        /// Id статуса эксплуатации аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус эксплуатации аккумулятора
        /// </summary>
        public string Status { get; set; }
    }

    public class BatteryReplacementStatus
    {
        /// <summary>
        /// Id статуса замены аккумулятора 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус замены аккумулятора 
        /// </summary>
        public string Status { get; set; }
    }
}
