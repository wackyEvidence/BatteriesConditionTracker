using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IGetData_All
    {
        public List<BatteryExploitationStatus> GetBatteryExploitationStatus_All();
        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All();
        public BindingList<BatteryClampType> GetBatteryClampType_All();
        public BindingList<BatterySubsystem> GetBatterySubsystem_All();
        public BindingList<BatteryTechnology> GetBatteryTechnology_All();
        public BindingList<BatteryModel> GetBatteryModel_All();
        public BindingList<Position> GetPosition_All();
        public BindingList<Structure> GetStructure_All();
        public BindingList<StructureType> GetStructureType_All();
        public BindingList<User> GetUser_All();
    }
}
