using BatteriesConditionTrackerLib.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
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

        public void CreateBatteryModelPhoto(string filePath)
        {
            throw new NotImplementedException();
        }

        public BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
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

        public void CreateConcreteBatteryPhoto(string filePath)
        {
            throw new NotImplementedException();
        }

        public Position CreatePosition(Position positionModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("position_name", positionModel.Name);
                parameters.Add("position_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spPositions_Insert", parameters, commandType: CommandType.StoredProcedure);

                positionModel.Id = parameters.Get<int>("position_id");
                return positionModel;
            }
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

        public BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel)
        {
            throw new NotImplementedException();
        }

        public BatteryModel DeleteBatteryModel(BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteBatteryModelPhoto(string filePath)
        {
            throw new NotImplementedException();
        }

        public BatterySoHMeasure DeleteBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            throw new NotImplementedException();
        }

        public BatterySubsystem DeleteBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            throw new NotImplementedException();
        }

        public BatteryTechnology DeleteBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            throw new NotImplementedException();
        }

        public ConcreteBattery DeleteConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteConcreteBatteryPhoto(string filePath)
        {
            throw new NotImplementedException();
        }

        public Position DeletePosition(Position positionModel)
        {
            throw new NotImplementedException();
        }

        public Structure DeleteStructure(Structure structureModel)
        {
            throw new NotImplementedException();
        }

        public StructureType DeleteStructureType(StructureType structureTypeModel)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(User userModel)
        {
            throw new NotImplementedException();
        }

        public BatteryClampType UpdateBatteryClampType(BatteryClampType clampTypeModel)
        {
            throw new NotImplementedException();
        }

        public BatteryModel UpdateBatteryModel(BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public BatterySoHMeasure UpdateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            throw new NotImplementedException();
        }

        public BatterySubsystem UpdateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            throw new NotImplementedException();
        }

        public BatteryTechnology UpdateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            throw new NotImplementedException();
        }

        public ConcreteBattery UpdateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            throw new NotImplementedException();
        }

        public Position UpdatePosition(Position positionModel)
        {
            throw new NotImplementedException();
        }

        public Structure UpdateStructure(Structure structureModel)
        {
            throw new NotImplementedException();
        }

        public StructureType UpdateStructureType(StructureType structureTypeModel)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User userModel)
        {
            throw new NotImplementedException();
        }
    }
}
