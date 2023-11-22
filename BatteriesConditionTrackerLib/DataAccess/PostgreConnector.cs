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
using System.ComponentModel;
using NpgsqlTypes;
using BatteriesConditionTrackerLib.DataAccess.Interfaces;

namespace BatteriesConditionTrackerLib.DataAccess
{
    internal class PostgreConnector : IDataConnection
    {
        public BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", clampTypeModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatteryClampTypes_Insert", parameters, commandType: CommandType.StoredProcedure);

                clampTypeModel.Id = parameters.Get<int>("p_id");
                return clampTypeModel;
            }
        }

        public BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", batterySubsystemModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatterySubsystems_Insert", parameters, commandType: CommandType.StoredProcedure);

                batterySubsystemModel.Id = parameters.Get<int>("p_id");
                return batterySubsystemModel;
            }
        }

        public BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", batteryTechnologyModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatteryTechnologies_Insert", parameters, commandType: CommandType.StoredProcedure);

                batteryTechnologyModel.Id = parameters.Get<int>("p_id");
                return batteryTechnologyModel;
            }
        }

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_brand", batteryModel.Brand, dbType: DbType.StringFixedLength, size: 50);
                parameters.Add("p_capacity", batteryModel.Capacity);
                parameters.Add("p_voltage", batteryModel.Voltage);
                parameters.Add("p_length", batteryModel.Length);
                parameters.Add("p_height", batteryModel.Height);
                parameters.Add("p_width", batteryModel.Width);
                parameters.Add("p_technology_id", batteryModel.Technology.Id);
                parameters.Add("p_clamp_type_id", batteryModel.ClampType.Id);
                parameters.Add("p_cost", batteryModel.Cost);
                parameters.Add("p_buffer_mode_service_time", batteryModel.BufferModeServiceTime);
                parameters.Add("p_soh_threshold", batteryModel.MinSoH);
                parameters.Add("p_name", batteryModel.Name, dbType: DbType.StringFixedLength, size: 50);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatteryModels_Insert", parameters, commandType: CommandType.StoredProcedure);

                batteryModel.Id = parameters.Get<int>("p_id");
                return batteryModel;
            }
        }

        public Position CreatePosition(Position positionModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", positionModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spPositions_Insert", parameters, commandType: CommandType.StoredProcedure);

                positionModel.Id = parameters.Get<int>("p_id");
                return positionModel;
            }
        }

        public Structure CreateStructure(Structure structureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", structureModel.Name);
                parameters.Add("p_type_id", structureModel.Type.Id);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spStructures_Insert", parameters, commandType: CommandType.StoredProcedure);

                structureModel.Id = parameters.Get<int>("p_id");
                return structureModel;
            }
        }

        public StructureType CreateStructureType(StructureType structureTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", structureTypeModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spStructureTypes_Insert", parameters, commandType: CommandType.StoredProcedure);

                structureTypeModel.Id = parameters.Get<int>("p_id");
                return structureTypeModel;
            }
        }

        public User CreateUser(User userModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_name", userModel.Name);
                parameters.Add("p_surname", userModel.Surname);
                parameters.Add("p_patronymic", userModel.Patronymic);
                parameters.Add("p_phone_number", userModel.PhoneNumber);
                parameters.Add("p_email", userModel.Email);
                parameters.Add("p_position_id", userModel.Position.Id);
                parameters.Add("p_supervisor_id", userModel.Supervisor == null ? null : userModel.Supervisor.Id);
                parameters.Add("p_password", userModel.Password);
                parameters.Add("p_is_admin", userModel.IsAdmin);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spUsers_Insert", parameters, commandType: CommandType.StoredProcedure);

                userModel.Id = parameters.Get<int>("p_id");
                return userModel;
            }
        }

        public ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_model_id", concreteBatteryModel.Model.Id);
                parameters.Add("p_exploitation_start", concreteBatteryModel.ExploitationStart.ToShortDateString());
                parameters.Add("p_exploitation_end", concreteBatteryModel.ExploitationEnd);
                parameters.Add("p_structure_id", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("p_subsystem_id", concreteBatteryModel.Subsystem.Id);
                parameters.Add("p_responsible_employee_id", concreteBatteryModel.ResponsibleWorker.Id);
                parameters.Add("p_exploitation_status_id", concreteBatteryModel.ExploitationStatus.Id);
                parameters.Add("p_replacement_status_id", concreteBatteryModel.ReplacementStatus.Id);
                parameters.Add("p_additional_notes", concreteBatteryModel.AdditionalNotes);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spConcreteBatteries_Insert", parameters, commandType: CommandType.StoredProcedure);

                concreteBatteryModel.Id = parameters.Get<int>("p_id");
                return concreteBatteryModel;
            }
        }

        public BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_battery_id", batterySoHMeasureModel.Battery.Id);
                parameters.Add("p_performing_employee_id", batterySoHMeasureModel.PerformingEmployee.Id);
                parameters.Add("p_measure_date", batterySoHMeasureModel.MeasureDate.ToShortDateString());    
                parameters.Add("p_soh", batterySoHMeasureModel.SoHValue);    
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatterySoHMeasures_Insert", parameters, commandType: CommandType.StoredProcedure);

                batterySoHMeasureModel.Id = parameters.Get<int>("p_id");
                return batterySoHMeasureModel;
            }
        }

        public void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                //  TODO реализовать сохранение в Яндекс.Диск
                foreach (var photo in photos)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                    parameters.Add("p_battery_id", batteryModel.Id);
                    parameters.Add("p_file_path", photo.DiskFilePath);

                    connection.Execute("spBatteryModelPhotos_Insert", parameters, commandType: CommandType.StoredProcedure);

                    photo.Id = parameters.Get<int>("p_id");
                }
            }
        }

        public void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                //  TODO реализовать сохранение в Яндекс.Диск
                foreach (var photo in photos) 
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                    parameters.Add("p_battery_id", concreteBattery.Id);
                    parameters.Add("p_file_path", photo.DiskFilePath);

                    connection.Execute("spConcreteBatteryPhotos_Insert", parameters, commandType: CommandType.StoredProcedure);

                    photo.Id = parameters.Get<int>("p_id");
                }
            }
        }

        public BatteryClampType UpdateBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", clampTypeModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", clampTypeModel.Name);

                connection.Execute("spBatteryClampTypes_Update", parameters, commandType: CommandType.StoredProcedure);

                return clampTypeModel;
            }
        }

        public BatterySubsystem UpdateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batterySubsystemModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", batterySubsystemModel.Name);

                connection.Execute("spBatterySubsystems_Update", parameters, commandType: CommandType.StoredProcedure);

                return batterySubsystemModel;
            }
        }

        public BatteryTechnology UpdateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using(var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batteryTechnologyModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", batteryTechnologyModel.Name);

                connection.Execute("spBatteryTechnologies_Update", parameters, commandType: CommandType.StoredProcedure);

                return batteryTechnologyModel;
            }
        }

        public BatteryModel UpdateBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batteryModel.Id, dbType: DbType.Int32);
                parameters.Add("p_brand", batteryModel.Brand, dbType: DbType.StringFixedLength, size: 50);
                parameters.Add("p_capacity", batteryModel.Capacity);
                parameters.Add("p_voltage", batteryModel.Voltage);
                parameters.Add("p_length", batteryModel.Length, dbType: DbType.Int32);
                parameters.Add("p_height", batteryModel.Height, dbType: DbType.Int32);
                parameters.Add("p_width", batteryModel.Width, dbType: DbType.Int32);
                parameters.Add("p_technology_id", batteryModel.Technology.Id);
                parameters.Add("p_clamp_type_id", batteryModel.ClampType.Id);
                parameters.Add("p_cost", batteryModel.Cost);
                parameters.Add("p_buffer_mode_service_time", batteryModel.BufferModeServiceTime);
                parameters.Add("p_soh_threshold", batteryModel.MinSoH, dbType: DbType.Int32);
                parameters.Add("p_name", batteryModel.Name, dbType: DbType.StringFixedLength, size: 50);

                connection.Execute("spBatteryModels_Update", parameters, commandType: CommandType.StoredProcedure);

                return batteryModel;
            }
        }

        public Position UpdatePosition(Position positionModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", positionModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", positionModel.Name, dbType: DbType.StringFixedLength, size: 50);

                connection.Execute("spPositions_Update", parameters, commandType: CommandType.StoredProcedure);

                return positionModel;
            }
        }

        public Structure UpdateStructure(Structure structureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", structureModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", structureModel.Name, dbType: DbType.StringFixedLength, size: 50);
                parameters.Add("p_type_id", structureModel.Type.Id, dbType: DbType.Int32);

                connection.Execute("spStructures_Update", parameters, commandType: CommandType.StoredProcedure);

                return structureModel;
            }
        }

        public StructureType UpdateStructureType(StructureType structureTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", structureTypeModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", structureTypeModel.Name, dbType: DbType.StringFixedLength, size: 50);

                connection.Execute("spStructureTypes_Update", parameters, commandType: CommandType.StoredProcedure);

                return structureTypeModel;
            }
        }

        public User UpdateUser(User userModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", 0, dbType: DbType.Int32);
                parameters.Add("p_name", userModel.Name);
                parameters.Add("p_surname", userModel.Surname);
                parameters.Add("p_patronymic", userModel.Patronymic);
                parameters.Add("p_phone_number", userModel.PhoneNumber);
                parameters.Add("p_email", userModel.Email);
                parameters.Add("p_position_id", userModel.Position.Id);
                parameters.Add("p_supervisor_id", userModel.Supervisor == null ? null : userModel.Supervisor.Id);
                parameters.Add("p_password", userModel.Password);
                parameters.Add("p_is_admin", userModel.IsAdmin);

                connection.Execute("spUsers_Update", parameters, commandType: CommandType.StoredProcedure);

                return userModel;
            }
        }

        public ConcreteBattery UpdateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", 0, dbType: DbType.Int32);
                parameters.Add("p_model_id", concreteBatteryModel.Model.Id);
                parameters.Add("p_exploitation_start", concreteBatteryModel.ExploitationStart.ToShortDateString());
                parameters.Add("p_exploitation_end", concreteBatteryModel.ExploitationEnd);
                parameters.Add("p_structure_id", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("p_subsystem_id", concreteBatteryModel.Subsystem.Id);
                parameters.Add("p_responsible_employee_id", concreteBatteryModel.ResponsibleWorker.Id);
                parameters.Add("p_exploitation_status_id", concreteBatteryModel.ExploitationStatus.Id);
                parameters.Add("p_replacement_status_id", concreteBatteryModel.ReplacementStatus.Id);
                parameters.Add("p_additional_notes", concreteBatteryModel.AdditionalNotes);

                connection.Execute("spConcreteBatteries_Update", parameters, commandType: CommandType.StoredProcedure);

                return concreteBatteryModel;
            }
        }

        public BatterySoHMeasure UpdateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batterySoHMeasureModel.Id, dbType: DbType.Int32);
                parameters.Add("p_battery_id", batterySoHMeasureModel.Battery.Id);
                parameters.Add("p_performing_employee_id", batterySoHMeasureModel.PerformingEmployee.Id);
                parameters.Add("p_measure_date", batterySoHMeasureModel.MeasureDate.ToShortDateString());
                parameters.Add("p_soh", batterySoHMeasureModel.SoHValue);

                connection.Execute("spBatterySoHMeasures_Update", parameters, commandType: CommandType.StoredProcedure);

                return batterySoHMeasureModel;
            }
        }

        public BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", clampTypeModel.Id, dbType: DbType.Int32);
                connection.Execute("spBatteryClampTypes_Delete", parameters, commandType: CommandType.StoredProcedure);

                return clampTypeModel;
            }
        }

        public BatterySubsystem DeleteBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batterySubsystemModel.Id, dbType: DbType.Int32);
                connection.Execute("spBatterySubsystems_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batterySubsystemModel;
            }
        }

        public BatteryTechnology DeleteBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batteryTechnologyModel.Id, dbType: DbType.Int32);
                connection.Execute("spBatteryTechnologies_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batteryTechnologyModel;
            }
        }

        public BatteryModel DeleteBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batteryModel.Id, dbType: DbType.Int32);

                connection.Execute("spBatteryModels_Delete", parameters, commandType: CommandType.StoredProcedure);

                return batteryModel;
            }
        }

        public Position DeletePosition(Position positionModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", positionModel.Id, dbType: DbType.Int32);
                connection.Execute("spPositions_Delete", parameters, commandType: CommandType.StoredProcedure);

                return positionModel;
            }
        }

        public Structure DeleteStructure(Structure structureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", structureModel.Id, dbType: DbType.Int32);
                connection.Execute("spStructures_Delete", parameters, commandType: CommandType.StoredProcedure);

                return structureModel;
            }
        }

        public StructureType DeleteStructureType(StructureType structureTypeModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", structureTypeModel.Id, dbType: DbType.Int32);
                connection.Execute("spStructureTypes_Delete", parameters, commandType: CommandType.StoredProcedure);

                return structureTypeModel;
            }
        }

        public User DeleteUser(User userModel)
        {
            using (var connection = new SqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", userModel.Id, dbType: DbType.Int32);

                connection.Execute("spUsers_Delete", parameters, commandType: CommandType.StoredProcedure);

                return userModel;
            }
        }

        public ConcreteBattery DeleteConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", concreteBatteryModel.Id, dbType: DbType.Int32);
                connection.Execute("spConcreteBatteries_Delete", parameters, commandType: CommandType.StoredProcedure);

                return concreteBatteryModel;
            }
        }

        public BatterySoHMeasure DeleteBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", batterySoHMeasureModel.Id, dbType: DbType.Int32);
                connection.Execute("spBatterySoHMeasures_Delete", parameters, commandType: CommandType.StoredProcedure);

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
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return connection.Query<BatteryExploitationStatus>("select * from BatteryExploitationStatuses").ToList();
        }

        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return connection.Query<BatteryReplacementStatus>("select * from BatteryReplacementStatuses").ToList();
        }
        public BindingList<BatteryClampType> GetBatteryClampType_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return new BindingList<BatteryClampType>(connection.Query<BatteryClampType>("select * from BatteryClampTypes").ToList());
        }

        public BindingList<BatterySubsystem> GetBatterySubsystem_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return new BindingList<BatterySubsystem>(connection.Query<BatterySubsystem>("select * from BatterySubsystems").ToList());
        }

        public BindingList<BatteryTechnology> GetBatteryTechnology_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return new BindingList<BatteryTechnology>(connection.Query<BatteryTechnology>("select * from BatteryTechnologies").ToList());
        }

        public BindingList<BatteryModel> GetBatteryModel_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "select * from (BatteryModels as bm left join BatteryTechnologies as bt on bm.technology_id = bt.id) left join BatteryClampTypes as bc on bm.clamp_type_id = bc.id;";
            return new BindingList<BatteryModel>(connection.Query<BatteryModel, BatteryTechnology, BatteryClampType, BatteryModel>(sql, (bm, bt, bct) => { bm.Technology = bt; bm.ClampType = bct; return bm; }).ToList());
        }

        public BindingList<Position> GetPosition_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return new BindingList<Position>(connection.Query<Position>("select * from Positions").ToList());
        }

        public BindingList<Structure> GetStructure_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "select * from Structures as s left join StructureTypes as t on s.type_id = t.id;";
            return new BindingList<Structure>(connection.Query<Structure, StructureType, Structure>(sql, (structure, type) => { structure.Type = type; return structure; }).ToList());
        }

        public BindingList<StructureType> GetStructureType_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            return new BindingList<StructureType>(connection.Query<StructureType>("select * from StructureTypes").ToList());
        }

        public BindingList<User> GetUser_All()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "select * from (Users as u left join Users as m on u.supervisor_id = m.id) left join positions as p on u.position_id = p.id;";
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
