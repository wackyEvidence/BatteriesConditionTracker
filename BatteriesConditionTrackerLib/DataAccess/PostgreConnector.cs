﻿using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess
{
    internal class PostgreConnector : IDataConnection
    {
        public BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel)
        {
            throw new NotImplementedException();
        }

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            throw new NotImplementedException();
        }

        public BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            throw new NotImplementedException();
        }

        public ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            throw new NotImplementedException();
        }

        public Position CreatePosition(Position positionModel)
        {
            throw new NotImplementedException();
        }

        public Structure CreateStructure(Structure structureModel)
        {
            throw new NotImplementedException();
        }

        public StructureType CreateStructureType(StructureType structureTypeModel)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User userModel)
        {
            throw new NotImplementedException();
        }
    }
}