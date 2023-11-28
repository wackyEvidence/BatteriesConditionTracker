using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IUpdateData
    {
        BatteryClampType UpdateBatteryClampType(BatteryClampType clampTypeModel);
        BatterySubsystem UpdateBatterySubsystem(BatterySubsystem batterySubsystemModel);
        BatteryTechnology UpdateBatteryTechnology(BatteryTechnology batteryTechnologyModel);
        BatteryModel UpdateBatteryModel(BatteryModel batteryModel);
        Position UpdatePosition(Position positionModel);
        Structure UpdateStructure(Structure structureModel);
        StructureType UpdateStructureType(StructureType structureTypeModel);
        User UpdateUser(User userModel);
        ConcreteBattery UpdateConcreteBattery(ConcreteBattery concreteBatteryModel);
        BatterySoHMeasure UpdateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel);

        void UpdateReplacementStatuses();

        void UpdateReplacementStatusesUpdateDate();
    }
}
