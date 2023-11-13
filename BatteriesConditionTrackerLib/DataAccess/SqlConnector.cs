using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;
using Dapper;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public Position CreatePosition(Position positionModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            { 
                // TO DO исправить в коде процедуры id на Id
                var parameters = new DynamicParameters();
                parameters.Add("@PositionName", positionModel.Name);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPositions_Insert", parameters, commandType: CommandType.StoredProcedure);

                positionModel.Id = parameters.Get<int>("id");
                return positionModel;
            }
        }

        public BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", clampTypeModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatteryClampTypes_Insert", parameters, commandType: CommandType.StoredProcedure);

                clampTypeModel.Id = parameters.Get<int>("id");
                return clampTypeModel;
            }
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
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@BatteryId", batterySoHMeasureModel.Battery.Id);
                parameters.Add("@PerformingEmployee", batterySoHMeasureModel.PerformingEmployee.Id);
                parameters.Add("@MeasureDate", batterySoHMeasureModel.MeasureDate);
                parameters.Add("@SoH", batterySoHMeasureModel.SoHValue);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatterySoHMeasures_Insert", parameters, commandType: CommandType.StoredProcedure);

                batterySoHMeasureModel.Id = parameters.Get<int>("id");
                return batterySoHMeasureModel;
            }
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
