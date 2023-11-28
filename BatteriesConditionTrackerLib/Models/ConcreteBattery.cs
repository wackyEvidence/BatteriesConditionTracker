using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

namespace BatteriesConditionTrackerLib.Models
{
    public class ConcreteBattery : IHaveId//, IHavePhotos
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
        public DateTime ExploitationStart { get; set; }
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
        /// Ответственный работник
        /// </summary> 
        public User ResponsibleEmployee { get; set; }
        /// <summary>
        /// Статус эксплуатации аккумулятора. Принимает два значения: эксплутируется/не эксплуатируется.
        /// </summary>
        public BatteryExploitationStatus ExploitationStatus { get; set; }
        /// <summary>
        /// Статус замены аккумулятора. Принимает три значения: требует замены/не требует замены/заменен.
        /// </summary>
        public BatteryReplacementStatus ReplacementStatus { get; set; }
        /// <summary>
        /// Примечания по аккумулятору 
        /// </summary>
        public string AdditionalNotes { get; set; }
        /// <summary>
        /// Дата последнего измерения емкости
        /// </summary>
        public DateTime? LastCapacityMeasureDate { get; set; }

        public static readonly Func<string[], ConcreteBattery> ModelCreation = columns => new ConcreteBattery(columns);
        public static readonly Func<ConcreteBattery, string> ModelToCSV = b => $"{b.Id},{b.Model.Id},{b.ExploitationStart},{b.ExploitationEnd}," +
           $"{b.InstallationStructure.Id},{b.Subsystem.Id},{b.ResponsibleEmployee.Id},{b.ExploitationStatus.Id}," +
           $"{b.ReplacementStatus.Id},{b.AdditionalNotes.Replace(",", "%%%")},{b.LastCapacityMeasureDate}";

        //public List<Photo> DisplayedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Photo> AddedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Photo> DeletedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ConcreteBattery() { }

        public ConcreteBattery(string id, BatteryModel model, BatteryExploitationStatus exploitationStatus, BatteryReplacementStatus replacementStatus, DateTime exploitationStart, DateTime? exploitationEnd, Structure structure, BatterySubsystem subsystem, User user, string additionalNotes)
        {
            Id = int.Parse(id);
            Model = model;
            ExploitationStart = exploitationStart; 
            ExploitationEnd = exploitationEnd == null? null : exploitationEnd;
            InstallationStructure = structure;
            Subsystem = subsystem;
            ResponsibleEmployee = user; 
            ExploitationStatus = exploitationStatus;
            ReplacementStatus = replacementStatus;
            AdditionalNotes = additionalNotes;
        }

        public ConcreteBattery(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Model = GlobalConfig.Connection.GetBatteryModel_ById(int.Parse(columns[1]));
            ExploitationStart = DateTime.Parse(columns[2]);
            DateTime.TryParse(columns[3], out DateTime exploitationEnd);
            ExploitationEnd = exploitationEnd;
            InstallationStructure = GlobalConfig.Connection.GetStructure_ById(int.Parse(columns[4])); 
            Subsystem = GlobalConfig.Connection.GetBatterySubsystem_ById(int.Parse(columns[5]));
            ResponsibleEmployee = GlobalConfig.Connection.GetUser_ById(int.Parse(columns[6])); 
            ExploitationStatus = GlobalConfig.Connection.GetBatteryExploitationStatus_ById(int.Parse(columns[7]));
            ReplacementStatus = GlobalConfig.Connection.GetBatteryReplacementStatus_ById(int.Parse(columns[8]));
            AdditionalNotes = columns[9].Replace("%%%", ",");
            LastCapacityMeasureDate = columns[10] == ""? null : DateTime.Parse(columns[10]);
        }
    }
}
