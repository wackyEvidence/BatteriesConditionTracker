using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IGetData_ById
    {
        public BatteryExploitationStatus GetBatteryExploitationStatus_ById(int id);
        public BatteryReplacementStatus GetBatteryReplacementStatus_ById(int id);
        public BatteryClampType GetBatteryClampType_ById(int id);
        public BatterySubsystem GetBatterySubsystem_ById(int id);
        public BatteryTechnology GetBatteryTechnology_ById(int id);
        public BatteryModel GetBatteryModel_ById(int id);
        public Position GetPosition_ById(int id);
        public Structure GetStructure_ById(int id);
        public StructureType GetStructureType_ById(int id);
        public User GetUser_ById(int id);
    }
}
