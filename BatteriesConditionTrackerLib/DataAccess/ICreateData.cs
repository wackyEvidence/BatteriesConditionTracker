﻿using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public interface ICreateData
    {
        BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel);
        BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel);
        BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel);
        BatteryModel CreateBatteryModel(BatteryModel batteryModel);
        Position CreatePosition(Position positionModel);
        Structure CreateStructure(Structure structureModel);
        StructureType CreateStructureType(StructureType structureTypeModel);
        User CreateUser(User userModel);
        ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel);
        BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel);
        void CreateBatteryModelPhoto(string filePath);
        void CreateConcreteBatteryPhoto(string filePath);
    }
}
