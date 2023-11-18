using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.DataAccess.TextHelper;
using System.Web;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PositionsFileName = "Positions.csv";
        private const string StructuresFileName = "Structures.csv";
        private const string BatteryModelsFileName = "BatteryModels.csv";
        private const string UsersFileName = "Users.csv";
        private const string StructureTypesFileName = "StructureTypes.csv";
        private const string BatterySubsystemsFileName = "BatterySubsystems.csv";
        private const string BatteryClampTypesFileName = "BatteryClampTypes.csv";
        private const string BatteryTechnologiesFileName = "BatteryTechnologies.csv";
        private const string ConcreteBatteriesFileName = "ConcreteBatteries.csv";
        private const string SoHMeasuresFileName = "SoHMeasures.csv";
        private const string ConcreteBatteryPhotosFileName = "ConcreteBatteryPhotos.csv";
        private const string BatteryModelPhotosFileName = "BatteryModelPhotos.csv"; 

        /// <summary>
        /// Добавляет в файл .csv запись о модели. 
        /// </summary>
        /// <typeparam name="T">Тип модели</typeparam>
        /// <param name="model">Модель, которую </param>
        /// <param name="fileName">Имя файла, в который нужно добавить модель</param>
        /// <param name="modelCreation">Делегат создания модели из массива значений строки</param>
        /// <param name="modelToCSV">Делегат преобразования модели в строку</param>
        /// <returns>Модель с сгенерированным Id</returns>
        private T CreateModel<T>(T model, string fileName, Func<string[], T> modelCreation, Func<T, string> modelToCSV)
            where T : IHaveId
        {
            var models = fileName.GetFullFilePath().LoadFile().ConvertToModels(modelCreation); 

            int newId = models.Count == 0? 1 : models.OrderByDescending(model => model.Id).First().Id + 1;

            model.Id = newId; 
            models.Add(model);

            if(model is IHavePhotos modelWithPhotos)
                // TO-DO Дописать сюда что-то 

            models.SaveToTextFile(fileName, modelToCSV);
            return model;
        }

        //public T UpdateModel<T>(T model, string fileName)
        //    where T : IHaveId
        //{

        //}

        public BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel)
        {
            Func<string[], BatteryClampType> modelCreation = columns => new BatteryClampType(columns);
            Func<BatteryClampType, string> modelToCSV = clampType => $"{clampType.Id},{clampType.Name}";

            return CreateModel(clampTypeModel, BatteryClampTypesFileName, modelCreation, modelToCSV); 
        }

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            Func<string[], BatteryModel> modelCreation = columns => new BatteryModel(columns);
            Func<BatteryModel, string> modelToCSV = bm => 
            $"{bm.Id},{bm.Name},{bm.Brand},{bm.Capacity},{bm.Voltage},{bm.Length},{bm.Height},{bm.Width},{bm.Technology.Id}," +
            $"{bm.ClampType.Id},{bm.Cost},{bm.BufferModeServiceTime},{bm.MinSoH}";

            return CreateModel(batteryModel, BatteryModelsFileName, modelCreation, modelToCSV);
        }

        public BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            Func<string[], BatterySoHMeasure> modelCreation = columns => new BatterySoHMeasure(columns);
            Func<BatterySoHMeasure, string> modelToCSV = soh => $"{soh.Id},{soh.Battery.Id},{soh.PerformingEmployee.Id},{soh.MeasureDate},{soh.SoHValue}";

            return CreateModel(batterySoHMeasureModel, SoHMeasuresFileName, modelCreation, modelToCSV);
        }

        public BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            Func<string[], BatterySubsystem> modelCreation = columns => new BatterySubsystem(columns);
            Func<BatterySubsystem, string> modelToCSV = subsystem => $"{subsystem.Id},{subsystem.Name}";

            return CreateModel(batterySubsystemModel, BatterySubsystemsFileName, modelCreation, modelToCSV);
        }

        public BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            Func<string[], BatteryTechnology> modelCreation = columns => new BatteryTechnology(columns);
            Func<BatteryTechnology, string> modelToCSV = technology => $"{technology.Id},{technology.Name}";

            return CreateModel(batteryTechnologyModel, BatteryTechnologiesFileName, modelCreation, modelToCSV);
        }

        public ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            Func<string[], ConcreteBattery> modelCreation = columns => new ConcreteBattery(columns);
            Func<ConcreteBattery, string> modelToCSV = b => $"{b.Id},{b.Model.Id},{b.ExploitationStart},{b.ExploitationEnd}," +
            $"{b.InstallationStructure.Id},{b.Subsystem.Id},{b.ResponsibleWorker.Id},{b.ExploitationStatus.Id}," +
            $"{b.ReplacementStatus.Id},{b.AdditionalNotes},{b.LastCapacityMeasureDate}";

            return CreateModel(concreteBatteryModel, ConcreteBatteriesFileName, modelCreation, modelToCSV);
        }

        public Position CreatePosition(Position positionModel)
        {
            Func<string[], Position> modelCreation = columns => new Position(columns);
            Func<Position, string> modelToCSV = position => $"{position.Id},{position.Name}"; 

            return CreateModel(positionModel, PositionsFileName, modelCreation , modelToCSV); 
        }

        public Structure CreateStructure(Structure structureModel)
        {
            Func<string[], Structure> modelCreation = columns => new Structure(columns);
            Func<Structure, string> modelToCSV = structure => $"{structure.Id},{structure.Name},{structure.Type.Id}";

            return CreateModel(structureModel, StructuresFileName, modelCreation, modelToCSV);
        }

        public StructureType CreateStructureType(StructureType structureTypeModel)
        {
            Func<string[], StructureType> modelCreation = columns => new StructureType(columns);
            Func<StructureType, string> modelToCSV = structureType => $"{structureType.Id},{structureType.Name}";

            return CreateModel(structureTypeModel, StructureTypesFileName, modelCreation, modelToCSV);
        }

        public User CreateUser(User userModel)
        {
            Func<string[], User> modelCreation = columns => new User(columns);
            Func<User, string> modelToCSV = user => $"{user.Id},{user.Name},{user.Surname},{user.Patronymic}," +
            $"{user.Password},{user.PhoneNumber},{user.Email},{user.Position.Id},{user.Supervisor.Id},{user.IsAdmin}";

            return CreateModel(userModel, UsersFileName, modelCreation, modelToCSV);
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

        public Position UpdatePosition(Position newPositionModel)
        {
            var positions = PositionsFileName.GetFullFilePath().LoadFile().ConvertToModels(columns => new Position(columns[0], columns[1]));
            var oldPositionModel = positions.Where(p => p.Id == newPositionModel.Id).FirstOrDefault();
            oldPositionModel = newPositionModel;
            positions.SaveToTextFile(PositionsFileName, position => ($"{position.Id},{position.Name}"));
            return newPositionModel;
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
