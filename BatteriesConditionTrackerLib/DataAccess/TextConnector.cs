using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.DataAccess.TextHelper;
using System.Web;
using System.ComponentModel;
using BatteriesConditionTrackerLib.Models.Interfaces;
using BatteriesConditionTrackerLib.DataAccess.Interfaces;
using System.CodeDom;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public class TextConnector : IDataConnection, IGetData_All, IGetData_ById
    {
        private const string BatteryExploitationStatusesFileName = "BatteryExploitationStatuses.csv";
        private const string BatteryReplacementStatusesFileName = "BatteryReplacementStatuses.csv";
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

        //
        // GENERIC METHODS
        //
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
            models.SaveToTextFile(fileName, modelToCSV);

            return model;
        }

        public T UpdateModel<T>(T model, string fileName, Func<string[], T> modelCreation, Func<T, string> modelToCSV)
            where T : IHaveId
        {
            var models = fileName.GetFullFilePath().LoadFile().ConvertToModels(modelCreation);
            var oldModel = models.Where(m => m.Id == model.Id).FirstOrDefault();
            oldModel = model;
            models.SaveToTextFile(fileName, modelToCSV); 

            return model;
        }

        public T DeleteModel<T>(T model, string fileName, Func<string[], T> modelCreation, Func<T, string> modelToCSV)
            where T : IHaveId
        {
            var models = fileName.GetFullFilePath().LoadFile().ConvertToModels(modelCreation);
            var modelToBeDeleted = models.Where(m => m.Id == model.Id).FirstOrDefault();
            models.Remove(modelToBeDeleted); 
            models.SaveToTextFile(fileName, modelToCSV);

            return model;
        }
        //
        // CREATE
        //
        public BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel)
        {
            return CreateModel(clampTypeModel, BatteryClampTypesFileName, BatteryClampType.ModelCreation, BatteryClampType.ModelToCSV); 
        }

        public BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            return CreateModel(batterySubsystemModel, BatterySubsystemsFileName, BatterySubsystem.ModelCreation, BatterySubsystem.ModelToCSV);
        }

        public BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            return CreateModel(batteryTechnologyModel, BatteryTechnologiesFileName, BatteryTechnology.ModelCreation, BatteryTechnology.ModelToCSV);
        }

        public BatteryModel CreateBatteryModel(BatteryModel batteryModel)
        {
            return CreateModel(batteryModel, BatteryModelsFileName, BatteryModel.ModelCreation, BatteryModel.ModelToCSV);
        }

        public Position CreatePosition(Position positionModel)
        {
            return CreateModel(positionModel, PositionsFileName, Position.ModelCreation, Position.ModelToCSV);
        }

        public Structure CreateStructure(Structure structureModel)
        {
            return CreateModel(structureModel, StructuresFileName, Structure.ModelCreation, Structure.ModelToCSV);
        }

        public StructureType CreateStructureType(StructureType structureTypeModel)
        {
            return CreateModel(structureTypeModel, StructureTypesFileName, StructureType.ModelCreation, StructureType.ModelToCSV);
        }


        public User CreateUser(User userModel)
        {
            return CreateModel(userModel, UsersFileName, User.ModelCreation, User.ModelToCSV);
        }

        public ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            return CreateModel(concreteBatteryModel, ConcreteBatteriesFileName, ConcreteBattery.ModelCreation, ConcreteBattery.ModelToCSV);
        }

        public BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            return CreateModel(batterySoHMeasureModel, SoHMeasuresFileName, BatterySoHMeasure.ModelCreation, BatterySoHMeasure.ModelToCSV);
        }

        public void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel)
        {
            throw new NotImplementedException();
        }

        public void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery)
        {
            throw new NotImplementedException();
        }
        //
        // UPDATE
        //
        public BatteryClampType UpdateBatteryClampType(BatteryClampType clampTypeModel)
        {
            return UpdateModel(clampTypeModel, BatteryClampTypesFileName, BatteryClampType.ModelCreation, BatteryClampType.ModelToCSV);
        }

        public BatterySubsystem UpdateBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            return UpdateModel(batterySubsystemModel, BatterySubsystemsFileName, BatterySubsystem.ModelCreation, BatterySubsystem.ModelToCSV);
        }

        public BatteryTechnology UpdateBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            return UpdateModel(batteryTechnologyModel, BatteryTechnologiesFileName, BatteryTechnology.ModelCreation, BatteryTechnology.ModelToCSV);
        }

        public BatteryModel UpdateBatteryModel(BatteryModel batteryModel)
        {
            return UpdateModel(batteryModel, BatteryModelsFileName, BatteryModel.ModelCreation, BatteryModel.ModelToCSV);
        }

        public Position UpdatePosition(Position positionModel)
        {
            return UpdateModel(positionModel, PositionsFileName, Position.ModelCreation, Position.ModelToCSV);
        }

        public Structure UpdateStructure(Structure structureModel)
        {
            return UpdateModel(structureModel, StructuresFileName, Structure.ModelCreation, Structure.ModelToCSV);
        }

        public StructureType UpdateStructureType(StructureType structureTypeModel)
        {
            return UpdateModel(structureTypeModel, StructureTypesFileName, StructureType.ModelCreation, StructureType.ModelToCSV);
        }

        public User UpdateUser(User userModel)
        {
            return UpdateModel(userModel, UsersFileName, User.ModelCreation, User.ModelToCSV);
        }

        public ConcreteBattery UpdateConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            return UpdateModel(concreteBatteryModel, ConcreteBatteriesFileName, ConcreteBattery.ModelCreation, ConcreteBattery.ModelToCSV);
        }

        public BatterySoHMeasure UpdateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            return UpdateModel(batterySoHMeasureModel, SoHMeasuresFileName, BatterySoHMeasure.ModelCreation, BatterySoHMeasure.ModelToCSV);
        }
        //
        // DELETE
        //
        public BatteryClampType DeleteBatteryClampType(BatteryClampType clampTypeModel)
        {
            return DeleteModel(clampTypeModel, BatteryClampTypesFileName, BatteryClampType.ModelCreation, BatteryClampType.ModelToCSV);
        }

        public BatterySubsystem DeleteBatterySubsystem(BatterySubsystem batterySubsystemModel)
        {
            return DeleteModel(batterySubsystemModel, BatterySubsystemsFileName, BatterySubsystem.ModelCreation, BatterySubsystem.ModelToCSV);
        }

        public BatteryTechnology DeleteBatteryTechnology(BatteryTechnology batteryTechnologyModel)
        {
            return DeleteModel(batteryTechnologyModel, BatteryTechnologiesFileName, BatteryTechnology.ModelCreation, BatteryTechnology.ModelToCSV);
        }

        public BatteryModel DeleteBatteryModel(BatteryModel batteryModel)
        {
            return DeleteModel(batteryModel, BatteryModelsFileName, BatteryModel.ModelCreation, BatteryModel.ModelToCSV);
        }

        public Position DeletePosition(Position positionModel)
        {
            return DeleteModel(positionModel, PositionsFileName, Position.ModelCreation, Position.ModelToCSV);
        }

        public Structure DeleteStructure(Structure structureModel)
        {
            return DeleteModel(structureModel, StructuresFileName, Structure.ModelCreation, Structure.ModelToCSV);
        }

        public StructureType DeleteStructureType(StructureType structureTypeModel)
        {
            return DeleteModel(structureTypeModel, StructureTypesFileName, StructureType.ModelCreation, StructureType.ModelToCSV);
        }

        public User DeleteUser(User userModel)
        {
            return DeleteModel(userModel, UsersFileName, User.ModelCreation, User.ModelToCSV);
        }

        public ConcreteBattery DeleteConcreteBattery(ConcreteBattery concreteBatteryModel)
        {
            return DeleteModel(concreteBatteryModel, ConcreteBatteriesFileName, ConcreteBattery.ModelCreation, ConcreteBattery.ModelToCSV);
        }

        public BatterySoHMeasure DeleteBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel)
        {
            return DeleteModel(batterySoHMeasureModel, SoHMeasuresFileName, BatterySoHMeasure.ModelCreation, BatterySoHMeasure.ModelToCSV);
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
            return BatteryExploitationStatusesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryExploitationStatus.ModelCreation); 
        }

        public List<BatteryReplacementStatus> GetBatteryReplacementStatus_All()
        {
            return BatteryReplacementStatusesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryReplacementStatus.ModelCreation); 
        }

        public BindingList<BatteryClampType> GetBatteryClampType_All()
        {
            return new BindingList<BatteryClampType>(BatteryClampTypesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryClampType.ModelCreation));
        }

        public BindingList<BatterySubsystem> GetBatterySubsystem_All()
        {
            return new BindingList<BatterySubsystem>(BatterySubsystemsFileName.GetFullFilePath().LoadFile().ConvertToModels(BatterySubsystem.ModelCreation));
        }

        public BindingList<BatteryTechnology> GetBatteryTechnology_All()
        {
            return new BindingList<BatteryTechnology>(BatteryTechnologiesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryTechnology.ModelCreation));
        }

        public BindingList<Position> GetPosition_All()
        {
            return new BindingList<Position>(PositionsFileName.GetFullFilePath().LoadFile().ConvertToModels(Position.ModelCreation));
        }

        public BindingList<User> GetUser_All()
        {
            return new BindingList<User>(UsersFileName.GetFullFilePath().LoadFile().ConvertToModels(User.ModelCreation));
        }

        public BindingList<BatteryModel> GetBatteryModel_All()
        {
            return new BindingList<BatteryModel>(BatteryModelsFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryModel.ModelCreation));
        }

        public BindingList<StructureType> GetStructureType_All()
        {
            return new BindingList<StructureType>(StructureTypesFileName.GetFullFilePath().LoadFile().ConvertToModels(StructureType.ModelCreation));
        }

        public BindingList<Structure> GetStructure_All()
        {
            return new BindingList<Structure>(StructuresFileName.GetFullFilePath().LoadFile().ConvertToModels(Structure.ModelCreation));
        }

        public BatteryExploitationStatus GetBatteryExploitationStatus_ById(int id)
        {
            return BatteryExploitationStatusesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryExploitationStatus.ModelCreation).Where(model => model.Id == id).First();
        }

        public BatteryReplacementStatus GetBatteryReplacementStatus_ById(int id)
        {
            return BatteryReplacementStatusesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryReplacementStatus.ModelCreation).Where(model => model.Id == id).First();
        }

        public BatteryClampType GetBatteryClampType_ById(int id)
        {
            return BatteryClampTypesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryClampType.ModelCreation).Where(model => model.Id == id).First();
        }

        public BatterySubsystem GetBatterySubsystem_ById(int id)
        {
            return BatterySubsystemsFileName.GetFullFilePath().LoadFile().ConvertToModels(BatterySubsystem.ModelCreation).Where(model => model.Id == id).First();
        }

        public BatteryTechnology GetBatteryTechnology_ById(int id)
        {
            return BatteryTechnologiesFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryTechnology.ModelCreation).Where(model => model.Id == id).First();
        }

        public Position GetPosition_ById(int id)
        {
            return PositionsFileName.GetFullFilePath().LoadFile().ConvertToModels(Position.ModelCreation).Where(model => model.Id == id).First();
        }

        public User GetUser_ById(int id)
        {
            return UsersFileName.GetFullFilePath().LoadFile().ConvertToModels(User.ModelCreation).Where(model => model.Id == id).First();
        }

        public BatteryModel GetBatteryModel_ById(int id)
        {
            return BatteryModelsFileName.GetFullFilePath().LoadFile().ConvertToModels(BatteryModel.ModelCreation).Where(model => model.Id == id).First();
        }

        public StructureType GetStructureType_ById(int id)
        {
            return StructureTypesFileName.GetFullFilePath().LoadFile().ConvertToModels(StructureType.ModelCreation).Where(model => model.Id == id).First();
        }

        public Structure GetStructure_ById(int id)
        {
            return StructuresFileName.GetFullFilePath().LoadFile().ConvertToModels(Structure.ModelCreation).Where(model => model.Id == id).First();
        }
    }
}
