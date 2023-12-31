﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatteryModel : IHaveId//, IHavePhotos
    {
        /// <summary>
        /// Id модели аккумулятора
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование аккумулятора. Обычно: бренд + емкость (напряжение)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Бренд аккумулятора
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Емкость аккумулятора (Ач) 
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// Напряжение аккумулятора (В)
        /// </summary>
        public double Voltage { get; set; }
        /// <summary>
        /// Длина аккумулятора (мм)
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Высота аккумулятора (мм)
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Ширина аккумулятора (мм)
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Технология, используемая в аккумуляторе
        /// </summary>
        public BatteryTechnology Technology { get; set; }
        /// <summary>
        /// Тип клемм, используемых в аккумуляторе
        /// </summary>
        public BatteryClampType ClampType { get; set; }
        /// <summary>
        /// Стоимость данной модели аккумулятора
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// Срок службы в буферном режиме (лет)
        /// </summary>
        public double BufferModeServiceTime { get; set; }
        /// <summary>
        /// Срок службы в циклическом режиме (число циклов)
        /// </summary>
        public int SoHThreshold { get; set; }
        /// <summary>
        /// Список фотографий этой модели аккумулятора
        /// </summary>
        //public List<Photo> DisplayedPhotos { get; set; }
        //public List<Photo> AddedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Photo> DeletedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static readonly Func<string[], BatteryModel> ModelCreation = columns => new BatteryModel(columns);
        public static readonly Func<BatteryModel, string> ModelToCSV = bm =>
            $"{bm.Id},{bm.Name},{bm.Brand},{bm.Capacity.ToString().Replace(',', '.')},{bm.Voltage.ToString().Replace(',', '.')},{bm.Length},{bm.Height},{bm.Width},{bm.Technology.Id}," +
            $"{bm.ClampType.Id},{bm.Cost},{bm.BufferModeServiceTime.ToString().Replace(',', '.')},{bm.SoHThreshold}";

        public BatteryModel() { }

        public BatteryModel(string id, string name, string brand, string capacity, string voltage, string length, string height, 
            string width, BatteryTechnology technology, BatteryClampType clampType, string cost, string bufferModeServiceTime, string minSoH)
        {
            Id = int.Parse(id); 
            Name = name; 
            Brand = brand;
            Capacity = double.Parse(capacity); 
            Voltage = double.Parse(voltage);
            Length = int.Parse(length); 
            Height = int.Parse(height);
            Width = int.Parse(width);
            Technology = technology; 
            ClampType = clampType;
            Cost = int.Parse(cost);
            BufferModeServiceTime = double.Parse(bufferModeServiceTime); 
            SoHThreshold = int.Parse(minSoH);
        }

        public BatteryModel(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
            Brand = columns[2];
            Capacity = double.Parse(columns[3].Replace('.', ','));
            Voltage = double.Parse(columns[4].Replace('.', ',')); 
            Length = int.Parse(columns[5]);
            Height = int.Parse(columns[6]);
            Width = int.Parse(columns[7]);
            Technology = GlobalConfig.Connection.GetBatteryTechnology_ById(int.Parse(columns[8]));
            ClampType = GlobalConfig.Connection.GetBatteryClampType_ById(int.Parse(columns[9]));
            Cost = int.Parse(columns[10]);
            BufferModeServiceTime = double.Parse(columns[11].Replace('.', ','));
            SoHThreshold = int.Parse(columns[12]); 
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
