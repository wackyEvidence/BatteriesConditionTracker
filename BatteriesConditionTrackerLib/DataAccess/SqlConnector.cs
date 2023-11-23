using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;
using Dapper;
using System.Configuration;
using System.ComponentModel;
using BatteriesConditionTrackerLib.DataAccess.Interfaces;
using Npgsql;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public class SqlConnector : IDataConnection
    {
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

        public Position CreatePosition(Position positionModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            { 
                var parameters = new DynamicParameters();
                parameters.Add("@Name", positionModel.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPositions_Insert", parameters, commandType: CommandType.StoredProcedure);

                positionModel.Id = parameters.Get<int>("Id");
                return positionModel;
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
                parameters.Add("@SupervisorId", userModel.Supervisor == null ? null : userModel.Supervisor.Id);
                parameters.Add("@Password", userModel.Password);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", parameters, commandType: CommandType.StoredProcedure);

                userModel.Id = parameters.Get<int>("@Id");
                return userModel;
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

        public void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            throw new NotImplementedException();
        }

        public BatteryClampType UpdateBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", clampTypeModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", clampTypeModel.Name);

                connection.Execute("dbo.spBatteryClampTypes_Update", parameters, commandType: CommandType.StoredProcedure);

                return clampTypeModel;
            }
        }

        public BatterySubsystem UpdateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batterySubsystemModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", batterySubsystemModel.Name);

                connection.Execute("dbo.spBatterySubsystems_Update", parameters, commandType: CommandType.StoredProcedure);

                return batterySubsystemModel;
            }
        }

        public BatteryTechnology UpdateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batteryTechnologyModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", batteryTechnologyModel.Name);

                connection.Execute("dbo.spBatteryTechnologies_Update", parameters, commandType: CommandType.StoredProcedure);

                return batteryTechnologyModel;
            }
        }

        public BatteryModel UpdateBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batteryModel.Id, dbType: DbType.Int32);
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

                connection.Execute("dbo.spBatteryModels_Update", parameters, commandType: CommandType.StoredProcedure);

                return batteryModel;
            }
        }

        public Position UpdatePosition(Position positionModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", positionModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", positionModel.Name);

                connection.Execute("dbo.spBatteryPositions_Update", parameters, commandType: CommandType.StoredProcedure);

                return positionModel;
            }
        }

        public Structure UpdateStructure(Structure structureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", structureModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", structureModel.Name);
                parameters.Add("@TypeId", structureModel.Type.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spStructures_Update", parameters, commandType: CommandType.StoredProcedure);

                return structureModel;
            }
        }

        public StructureType UpdateStructureType(StructureType structureTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", structureTypeModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", structureTypeModel.Name);

                connection.Execute("dbo.spStructureTypes_Update", parameters, commandType: CommandType.StoredProcedure);

                return structureTypeModel;
            }
        }

        public User UpdateUser(User userModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", userModel.Id, dbType: DbType.Int32);
                parameters.Add("@Name", userModel.Name);
                parameters.Add("@Surname", userModel.Surname);
                parameters.Add("@Patronymic", userModel.PhoneNumber);
                parameters.Add("@Email", userModel.Email);
                parameters.Add("@PositionId", userModel.Position.Id);
                parameters.Add("@SupervisorId", userModel.Supervisor == null ? null : userModel.Supervisor.Id);
                parameters.Add("@Password", userModel.Password);

                connection.Execute("dbo.spUsers_Update", parameters, commandType: CommandType.StoredProcedure);

                return userModel;
            }
        }

        public ConcreteBattery UpdateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", concreteBatteryModel.Id, dbType: DbType.Int32);
                parameters.Add("@ModelId", concreteBatteryModel.Model.Id);
                parameters.Add("@ExploitationStart", concreteBatteryModel.ExploitationStart.ToShortDateString());
                parameters.Add("@ExploitationEnd", concreteBatteryModel.ExploitationEnd == null ? null : concreteBatteryModel.ExploitationEnd);
                parameters.Add("@StructureId", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("@SubsystemId", concreteBatteryModel.Subsystem.Id);
                parameters.Add("@ResponsibleEmployeeId", concreteBatteryModel.ResponsibleWorker.Id);
                parameters.Add("@ExploitationStatusId", concreteBatteryModel.ExploitationStatus.Id);
                parameters.Add("@ReplacementStatusId", concreteBatteryModel.ReplacementStatus.Id);
                parameters.Add("@AdditionalNotes", concreteBatteryModel.AdditionalNotes);

                connection.Execute("dbo.spConcreteBatteries_Update", parameters, commandType: CommandType.StoredProcedure);

                return concreteBatteryModel;
            }
        }

        public BatterySoHMeasure UpdateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batterySoHMeasureModel.Id, dbType: DbType.Int32);
                parameters.Add("@BatteryId", batterySoHMeasureModel.Battery.Id);
                parameters.Add("@PerformingEmployeeId", batterySoHMeasureModel.PerformingEmployee.Id);
                parameters.Add("@MeasureDate", batterySoHMeasureModel.MeasureDate);
                parameters.Add("@SoH", batterySoHMeasureModel.SoHValue);

                connection.Execute("dbo.spBatterySoHMeasures_Update", parameters, commandType: CommandType.StoredProcedure);

                return batterySoHMeasureModel;
            }
        }

        public BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", clampTypeModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spBatteryClampTypes_Delete", parameters, commandType: CommandType.StoredProcedure);

                return clampTypeModel;
            }
        }

        public BatterySubsystem DeleteBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batterySubsystemModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spBatterySubsystems_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batterySubsystemModel;
            }
        }

        public BatteryTechnology DeleteBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batteryTechnologyModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spBatteryTechnologies_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batteryTechnologyModel;
            }
        }

        public BatteryModel DeleteBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batteryModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spBatteryModels_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batteryModel;
            }
        }

        public Position DeletePosition(Position positionModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", positionModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spPositions_Delete", parameters, commandType: CommandType.StoredProcedure);

                return positionModel;
            }
        }

        public Structure DeleteStructure(Structure structureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", structureModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spStructures_Delete", parameters, commandType: CommandType.StoredProcedure);

                return structureModel;
            }
        }

        public StructureType DeleteStructureType(StructureType structureTypeModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", structureTypeModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spStructureTypes_Delete", parameters, commandType: CommandType.StoredProcedure);

                return structureTypeModel;
            }
        }

        public User DeleteUser(User userModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", userModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spUsers_Delete", parameters, commandType: CommandType.StoredProcedure);

                return userModel;
            }
        }

        public ConcreteBattery DeleteConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", concreteBatteryModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spConcreteBatteries_Delete", parameters, commandType: CommandType.StoredProcedure);

                return concreteBatteryModel;
            }
        }
        public BatterySoHMeasure DeleteBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", batterySoHMeasureModel.Id, dbType: DbType.Int32);

                connection.Execute("dbo.spBatterySoHMeasures_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batterySoHMeasureModel;
            }
        }

        public void DeleteBatteryModelPhoto(List<Photo> photos, BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteConcreteBatteryPhoto(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            throw new NotImplementedException();
        }

        public List<BatteryExploitationStatus> GetBatteryExploitationStatus_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return connection.Query<BatteryExploitationStatus>("SELECT * FROM BatteryExploitationStatuses").ToList();
        }

        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return connection.Query<BatteryReplacementStatus>("SELECT * FROM BatteryReplacementStatuses").ToList();
        }

        public BindingList<BatteryClampType> GetBatteryClampType_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return new BindingList<BatteryClampType>(connection.Query<BatteryClampType>("SELECT * FROM BatteryClampTypes").ToList());
        }

        public BindingList<BatterySubsystem> GetBatterySubsystem_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return new BindingList<BatterySubsystem>(connection.Query<BatterySubsystem>("SELECT * FROM BatterySubsystems").ToList());
        }

        public BindingList<BatteryTechnology> GetBatteryTechnology_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return new BindingList<BatteryTechnology>(connection.Query<BatteryTechnology>("SELECT * FROM BatteryTechnologies").ToList());
        }

        public BindingList<BatteryModel> GetBatteryModel_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            var sql = "select * from (BatteryModels bm left join BatteryTechnologies bt on bm.technology_id = bt.id) left join BatteryClampTypes bc on bm.clamp_type_id = bc.id;";
            return new BindingList<BatteryModel>(connection.Query<BatteryModel, BatteryTechnology, BatteryClampType, BatteryModel>(sql, (bm, bt, bct) => { bm.Technology = bt; bm.ClampType = bct; return bm; }).ToList());
        }

        public BindingList<Position> GetPosition_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return new BindingList<Position>(connection.Query<Position>("SELECT * FROM Positions").ToList());
        }

        public BindingList<Structure> GetStructure_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            var sql = "select * from Structures s left join StructureTypes t on s.type_id = t.id;";
            return new BindingList<Structure>(connection.Query<Structure, StructureType, Structure>(sql, (structure, type) => { structure.Type = type; return structure; }).ToList());
        }

        public BindingList<StructureType> GetStructureType_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            return new BindingList<StructureType>(connection.Query<StructureType>("SELECT * FROM StructureTypes").ToList());
        }

        public BindingList<User> GetUser_All()
        {
            using var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerSQL"));
            var sql = "select * from (Users u left join Users m on u.supervisor_id = m.id) left join positions p on u.position_id = p.id;";
            return new BindingList<User>(connection.Query<User, User, Position, User>(sql, (u, m, p) => { u.Supervisor = m; u.Position = p; return u; }).ToList());
        }

        public BatteryExploitationStatus GetBatteryExploitationStatus_ById(int id)
        {
            throw new NotImplementedException();
        }

        public BatteryReplacementStatus GetBatteryReplacementStatus_ById(int id)
        {
            throw new NotImplementedException();
        }

        public BatteryClampType GetBatteryClampType_ById(int id)
        {
            throw new NotImplementedException();
        }

        public BatterySubsystem GetBatterySubsystem_ById(int id)
        {
            throw new NotImplementedException();
        }

        public BatteryTechnology GetBatteryTechnology_ById(int id)
        {
            throw new NotImplementedException();
        }

        public BatteryModel GetBatteryModel_ById(int id)
        {
            throw new NotImplementedException();
        }

        public Position GetPosition_ById(int id)
        {
            throw new NotImplementedException();
        }

        public Structure GetStructure_ById(int id)
        {
            throw new NotImplementedException();
        }

        public StructureType GetStructureType_ById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser_ById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
