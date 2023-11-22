using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IDeleteData
    {
        BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel);
        BatterySubsystem DeleteBatterySubsystem(BatterySubsystem batterySubsystemModel);
        BatteryTechnology DeleteBatteryTechnology(BatteryTechnology batteryTechnologyModel);
        BatteryModel DeleteBatteryModel(BatteryModel batteryModel);
        Position DeletePosition(Position positionModel);
        Structure DeleteStructure(Structure structureModel);
        StructureType DeleteStructureType(StructureType structureTypeModel);
        User DeleteUser(User userModel);
        ConcreteBattery DeleteConcreteBattery(ConcreteBattery concreteBatteryModel);
        BatterySoHMeasure DeleteBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel);
        void DeleteBatteryModelPhoto(List<Photo> photos, BatteryModel batteryModel);
        void DeleteConcreteBatteryPhoto(List<Photo> photos, ConcreteBattery concreteBattery);
    }
}
