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
using System.Security.Cryptography.X509Certificates;

namespace BatteriesConditionTrackerLib.DataAccess
{
    internal class PostgreConnector : IDataConnection
    {
        #region ICreateData
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
                parameters.Add("p_soh_threshold", batteryModel.SoHThreshold);
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
                parameters.Add("p_exploitation_start", concreteBatteryModel.ExploitationStart, dbType: DbType.Date);
                parameters.Add("p_exploitation_end", concreteBatteryModel.ExploitationEnd, dbType: DbType.Date);
                parameters.Add("p_structure_id", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("p_subsystem_id", concreteBatteryModel.Subsystem.Id);
                parameters.Add("p_responsible_employee_id", concreteBatteryModel.ResponsibleEmployee.Id);
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
                parameters.Add("p_measure_date", batterySoHMeasureModel.MeasureDate, dbType: DbType.Date);    
                parameters.Add("p_soh", batterySoHMeasureModel.SoH);    
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

        #endregion

        #region IUpdateData

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
                parameters.Add("p_soh_threshold", batteryModel.SoHThreshold, dbType: DbType.Int32);
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
                parameters.Add("p_id", userModel.Id, dbType: DbType.Int32);
                parameters.Add("p_name", userModel.Name);
                parameters.Add("p_surname", userModel.Surname);
                parameters.Add("p_patronymic", userModel.Patronymic);
                parameters.Add("p_phone_number", userModel.PhoneNumber);
                parameters.Add("p_email", userModel.Email);
                parameters.Add("p_position_id", userModel.Position.Id);
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
                parameters.Add("p_id", concreteBatteryModel.Id, dbType: DbType.Int32);
                parameters.Add("p_model_id", concreteBatteryModel.Model.Id);
                parameters.Add("p_exploitation_start", concreteBatteryModel.ExploitationStart, DbType.Date);
                parameters.Add("p_exploitation_end", concreteBatteryModel.ExploitationEnd, DbType.Date);
                parameters.Add("p_structure_id", concreteBatteryModel.InstallationStructure.Id);
                parameters.Add("p_subsystem_id", concreteBatteryModel.Subsystem.Id);
                parameters.Add("p_responsible_employee_id", concreteBatteryModel.ResponsibleEmployee.Id);
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
                parameters.Add("p_measure_date", batterySoHMeasureModel.MeasureDate, dbType: DbType.Date);
                parameters.Add("p_soh", batterySoHMeasureModel.SoH);

                connection.Execute("spBatterySoHMeasures_Update", parameters, commandType: CommandType.StoredProcedure);

                return batterySoHMeasureModel;
            }
        }

        public void UpdateReplacementStatuses()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            connection.Execute("spConcreteBatteries_UpdateReplacementStatuses", commandType: CommandType.StoredProcedure);
        }

        public void UpdateReplacementStatusesUpdateDate()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            connection.Execute("spLastReplacementStatusesUpdate_Update", commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region IDeleteData

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

        #endregion

        #region IGetData_All

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

            var sql = "select u.id as id, u.name as name, u.surname as surname, u.patronymic as patronymic, u.phone_number as phonenumber, u.email as email, u.password as password, u.is_admin as isadmin, " +
                " p.* from Users as u left join Positions as p on u.position_id = p.id where u.id > 1";
            
            var usersList = connection.Query<User, Position, User>(
                sql, 
                (user, position) => { user.Position = position; return user; }
                ).ToList();

            return new BindingList<User>(usersList);
        }

        public BindingList<ConcreteBattery> GetConcreteBattery_All()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));

            var sql = 
                "select * from ConcreteBatteries as cb \r\n" +
                "left join BatteryModels as bm ON cb.model_id = bm.id \r\n" +
                "left join Structures as s ON cb.structure_id = s.id \r\n" +
                "left join BatterySubsystems as bs ON cb.subsystem_id = bs.id \r\n" +
                "left join Users as u ON cb.responsible_employee_id = u.id \r\n" +
                "left join BatteryExploitationStatuses as es ON cb.exploitation_status_id = es.id \r\n" +
                "left join BatteryReplacementStatuses as rs ON cb.replacement_status_id = rs.id ";

            Func<ConcreteBattery, BatteryModel, Structure, BatterySubsystem, User, BatteryExploitationStatus, BatteryReplacementStatus, ConcreteBattery> mappingFunc =
                ((cb, bm, s, bs, u, es, rs) =>
                    {
                        cb.Model = bm;
                        cb.InstallationStructure = s;
                        cb.Subsystem = bs;
                        cb.ResponsibleEmployee = u;
                        cb.ExploitationStatus = es;
                        cb.ReplacementStatus = rs;
                        return cb;
                    }
                );

            return new BindingList<ConcreteBattery>(connection.Query(sql, mappingFunc).ToList());
        }

        public DateTime GetLastReplacementStatusesUpdateDate()
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "SELECT * FROM LastReplacementStatusesUpdate;";
            return connection.QuerySingle<DateTime>(sql);
        }

        //TODO провести рефакторинг методов ниже, выделить метод GetDistinct 

        public List<string> GetAvailableBrands_All()
        {
            var output = new List<string>();
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "SELECT DISTINCT brand FROM BatteryModels;";
            var command = new NpgsqlCommand(sql, connection);
            connection.Open(); 
            var reader = command.ExecuteReader();

            while (reader.Read())
                output.Add(reader[0].ToString());

            return output;
        }

        public List<string> GetAvailableCapacities_All()
        {
            var output = new List<string>();
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "SELECT DISTINCT capacity FROM BatteryModels;";
            var command = new NpgsqlCommand(sql, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
                output.Add(reader[0].ToString());

            return output;
        }

        #endregion

        #region IGetData_ById
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

        public BindingList<BatterySoHMeasure> GetBatterySoHMeasure_ById(int id)
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "select * from BatterySoHMeasures as sm left join Users u on sm.performing_employee_id = u.id where sm.battery_id = @Id";
            Func<BatterySoHMeasure, User, BatterySoHMeasure> mappingFunc = (measure, user) => { measure.PerformingEmployee = user; return measure; };
            return new BindingList<BatterySoHMeasure>(connection.Query(sql, mappingFunc, new { Id = id }).ToList());
        }

        #endregion  

        public User GetUser_ByLogin(string login)
        {
            using var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre"));
            var sql = "select * from Users as u left join Positions as p on u.position_id = p.id where u.email = @Login;";
            
            return connection.Query<User, Position, User>(sql, (u, p) => { u.Position = p; return u; }, new { Login = login }).FirstOrDefault();
        }

       
    }
}
