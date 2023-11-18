using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess
{
    public interface ICreateData
    {
        BatteryClampType CreateBatteryClampType(BatteryClampType clampTypeModel);
        BatterySubsystem CreateBatterySubsystem(BatterySubsystem batterySubsystemModel);
        BatteryTechnology CreateBatteryTechnology(BatteryTechnology batteryTechnologyModel);
        BatteryModel CreateBatteryModel(BatteryModel batteryModel);
        Position CreatePosition(Position positionModel);
        Structure CreateStructure(Structure structureModel);
        StructureType CreateStructureType(StructureType structureTypeModel);
        User CreateUser(User userModel);
        ConcreteBattery CreateConcreteBattery(ConcreteBattery concreteBatteryModel);
        BatterySoHMeasure CreateBatterySoHMeasure(BatterySoHMeasure batterySoHMeasureModel);
        /// <summary>
        /// Сохраняет данные о фотографиях модели аккумулятора в хранилище данных и загружает их на Яндекс.Диск
        /// </summary>
        /// <param name="photos">Список путей к файлам фотографий</param>
        void CreateBatteryModelPhotos(List<Photo> photos, BatteryModel batteryModel);
        /// <summary>
        /// Сохраняет данные о фотографиях конкретного аккумулятора в хранилище данных и загружает их на Яндекс.Диск
        /// </summary>
        /// <param name="photos"></param>
        void CreateConcreteBatteryPhotos(List<Photo> photos, ConcreteBattery concreteBattery);
    }
}
