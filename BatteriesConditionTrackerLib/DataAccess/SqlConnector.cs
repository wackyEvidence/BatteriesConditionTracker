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
                parameters.Add("@Name", positionModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPositions_Insert", parameters, commandType: CommandType.StoredProcedure);

                positionModel.Id = parameters.Get<int>("Id");
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

                clampTypeModel.Id = parameters.Get<int>("Id");
                return clampTypeModel;
            }
        }

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", batteryModel.Name);
                parameters.Add("@Brand", batteryModel.Brand);
                parameters.Add("@Capacity", batteryModel.Capacity);
                parameters.Add("@Voltage", batteryModel.Voltage);
                parameters.Add("@Length", batteryModel.Length);
                parameters.Add("@Height", batteryModel.Height);
                parameters.Add("@Width", batteryModel.Width);
                parameters.Add("@TechnologyId", batteryModel.Technology.Id);
                parameters.Add("@ClampTypeId", batteryModel.ClampType.Id);
                parameters.Add("@Cost", batteryModel.Cost);
                parameters.Add("@BufferModeServiceTime", batteryModel.BufferModeServiceTime);
                parameters.Add("@SoHThreshold", batteryModel.MinSoH);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatteryModels_Insert", parameters, commandType: CommandType.StoredProcedure);

                batteryModel.Id = parameters.Get<int>("@Id");
                return batteryModel;
            }
        }

        public void CreateBatteryModelPhotos(string filePath)
        {
            throw new NotImplementedException();
        }

        public BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@BatteryId", batterySoHMeasureModel.Battery.Id);
                parameters.Add("@PerformingEmployeeId", batterySoHMeasureModel.PerformingEmployee.Id);
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
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", batterySubsystemModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatterySubsystems_Insert", parameters, commandType: CommandType.StoredProcedure);

                batterySubsystemModel.Id = parameters.Get<int>("@Id");
                return batterySubsystemModel;
            }
        }

        public BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", batteryTechnologyModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatteryTechnologies_Insert", parameters, commandType: CommandType.StoredProcedure);

                batteryTechnologyModel.Id = parameters.Get<int>("@Id");
                return batteryTechnologyModel;
            }
        }

        public ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ModelId", concreteBatteryModel.Model.Id);
                parameters.Add("@ExploitationStart", concreteBatteryModel.ExploitationStart.ToShortDateString());
                parameters.Add("@ExploitationEnd", concreteBatteryModel.ExploitationEnd == null? null : concreteBatteryModel.ExploitationEnd);
                parameters.Add("@StructureId", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("@SubsystemId", concreteBatteryModel.Subsystem.Id);
                parameters.Add("@ResponsibleEmployeeId", concreteBatteryModel.ResponsibleWorker.Id);
                parameters.Add("@ExploitationStatusId", concreteBatteryModel.ExploitationStatus.Id);
                parameters.Add("@ReplacementStatusId", concreteBatteryModel.ReplacementStatus.Id);
                parameters.Add("@AdditionalNotes", concreteBatteryModel.AdditionalNotes);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spConcreteBatteries_Insert", parameters, commandType: CommandType.StoredProcedure);

                concreteBatteryModel.Id = parameters.Get<int>("@Id");
                return concreteBatteryModel;
            }
        }

        public Structure CreateStructure(Structure structureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {   
                var parameters = new DynamicParameters();
                parameters.Add("@Name", structureModel.Name);
                parameters.Add("@TypeId", structureModel.Type.Id);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStructures_Insert", parameters, commandType: CommandType.StoredProcedure);

                structureModel.Id = parameters.Get<int>("@Id");
                return structureModel;
            }
        }

        public StructureType CreateStructureType(StructureType structureTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", structureTypeModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStructureTypes_Insert", parameters, commandType: CommandType.StoredProcedure);

                structureTypeModel.Id = parameters.Get<int>("@Id");
                return structureTypeModel;
            }
        }

        public User CreateUser(User userModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", userModel.Name);
                parameters.Add("@Surname", userModel.Surname);
                parameters.Add("@Patronymic", userModel.PhoneNumber);
                parameters.Add("@Email", userModel.Email);
                parameters.Add("@PositionId", userModel.Position.Id);
                parameters.Add("@SupervisorId", userModel.Supervisor == null? null : userModel.Supervisor.Id);
                parameters.Add("@Password", userModel.Password);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", parameters, commandType: CommandType.StoredProcedure);

                userModel.Id = parameters.Get<int>("@Id");
                return userModel;
            }
        }

        public BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel)
        {
            throw new NotImplementedException();
        }

        public BatteryModel DeleteBatteryModel(BatteryModel batteryModel)
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

        public void DeleteBatteryModelPhoto(List<Photo> photos, BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteConcreteBatteryPhoto(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            throw new NotImplementedException();
        }

        public void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            throw new NotImplementedException();
        }

        public List<BatteryExploitationStatus> GetBatteryExploitationStatus_All()
        {
            throw new NotImplementedException();
        }

        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All()
        {
            throw new NotImplementedException();
        }
    }
}
