using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class ConcreteBattery
    {
        /// <summary>
        /// Id данного аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Модель аккумулятора
        /// </summary>
        public BatteryModel Model { get; set; }
        /// <summary>
        /// Дата начала эксплуатации аккумулятора
        /// </summary>
        public DateTime? ExploitationStart { get; set; }
        /// <summary>
        /// Дата окончания эксплуатации аккумулятора 
        /// </summary>
        public DateTime? ExploitationEnd { get; set; }
        /// <summary>
        /// Объект, на котором установлен аккумулятор
        /// </summary>
        public Structure InstallationStructure { get; set; }
        /// <summary>
        /// Подсистема, в которой установлен аккумулятор
        /// </summary>
        public BatterySubsystem Subsystem { get; set; }
        /// <summary>
        /// Дата производства аккумулятора
        /// </summary>
        public DateTime ManufactureDate { get; set; }
        /// <summary>
        /// Ответственный работник
        /// </summary> 
        public User ResponsibleWorker { get; set; }
        /// <summary>
        /// Статус эксплуатации аккумулятора. Принимает два значения: эксплутируется/не эксплуатируется.
        /// </summary>
        public BatteryExploitationStatus ExploitationStatus { get; set; }
        /// <summary>
        /// Статус замены аккумулятора. Принимает три значения: требует замены/не требует замены/заменен.
        /// </summary>
        public BatteryReplacementStatus ReplacementStatus { get; set; }
        /// <summary>
        /// Дата последнего измерения емкости
        /// </summary>
        public DateTime? LastCapacityMeasureDate { get; set; }
        /// <summary>
        /// Примечания по аккумулятору 
        /// </summary>
        public string AdditionalNotes { get; set; }

        /// <summary>
        /// Список фотографий этого аккумулятора
        /// </summary>
        public List<string> Photos { get; set; } = new List<string>();
    }
}
