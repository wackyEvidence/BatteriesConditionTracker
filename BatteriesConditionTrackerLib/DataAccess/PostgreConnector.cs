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

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                var parameters = new DynamicParameters();
               
                parameters.Add("p_brand", batteryModel.Brand);
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
                parameters.Add("p_name", batteryModel.Name);
                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spBatteryModels_Insert", parameters, commandType: CommandType.StoredProcedure);

                batteryModel.Id = parameters.Get<int>("p_id");
                return batteryModel;
            }
        }

        public void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                //  TO-DO реализовать сохранение в Яндекс.Диск
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
        
        public void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.GetConnectionString("BatteriesConditionTrackerPostgre")))
            {
                //  TO-DO реализовать сохранение в Яндекс.Диск
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
                parameters.Add("p_supervisor_id", userModel.Supervisor == null? null: userModel.Supervisor.Id);
                parameters.Add("p_password", userModel.Password); 
                parameters.Add("p_is_admin", userModel.IsAdmin); 


                parameters.Add("p_id", 0, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("spUsers_Insert", parameters, commandType: CommandType.StoredProcedure);

                userModel.Id = parameters.Get<int>("p_id");
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

        public void DeleteBatteryModelPhoto(List<Photo> photos, BatteryModel batteryModel)
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

        public void DeleteConcreteBatteryPhoto(List<Photo> photos, ConcreteBattery concreteBattery)
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

        public List<BatteryExploitationStatus> GetBatteryExploitationStatus_All()
        {
            throw new NotImplementedException();
        }

        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All()
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
