using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatteryModel : IHaveId, IHavePhotos
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
        public decimal Cost { get; set; }
        /// <summary>
        /// Срок службы в буферном режиме (лет)
        /// </summary>
        public double BufferModeServiceTime { get; set; }
        /// <summary>
        /// Срок службы в циклическом режиме (число циклов)
        /// </summary>
        public int MinSoH { get; set; }
        /// <summary>
        /// Список фотографий этой модели аккумулятора
        /// </summary>
        public List<Photo> DisplayedPhotos { get; set; }
        public List<Photo> AddedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Photo> DeletedPhotos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BatteryModel() { }

        // TODO - Разобраться с назначением полей Technology и ClampType в конструкторах.
        public BatteryModel(string name, string brand, string capacity, string voltage, 
            string length, string height, string width, string technology, string clampType, string cost, 
            string bufferModeServiceTime, string minSoH, List<Photo> photoPaths)
        {
            Name = name; 
            Brand = brand;
            Capacity = double.Parse(capacity); 
            Voltage = double.Parse(voltage);
            Length = int.Parse(length); 
            Height = int.Parse(height);
            Width = int.Parse(width);
            Technology = new BatteryTechnology() { Id = int.Parse(technology) }; 
            ClampType = new BatteryClampType() { Id = int.Parse(clampType) };
            Cost = decimal.Parse(cost);
            BufferModeServiceTime = int.Parse(bufferModeServiceTime); 
            MinSoH = int.Parse(minSoH);
            DisplayedPhotos = photoPaths;
        }

        public BatteryModel(string[] columns)
        {
            Id = int.Parse(columns[0]); 
            Name = columns[1];
            Brand = columns[2];
            Capacity = double.Parse(columns[3]);
            Voltage = double.Parse(columns[4]); 
            Length = int.Parse(columns[5]);
            Height = int.Parse(columns[6]);
            Width = int.Parse(columns[7]);
            Technology = new BatteryTechnology() { Id = int.Parse(columns[8]) };
            ClampType = new BatteryClampType() { Id = int.Parse(columns[9]) };
            Cost = decimal.Parse(columns[10]);
            BufferModeServiceTime = double.Parse(columns[11]);
            MinSoH = int.Parse(columns[12]); 
        }

        public void SavePhotos()
        {
            throw new NotImplementedException();
        }

        public void DeletePhotos()
        {
            throw new NotImplementedException();
        }

        public List<string> GetPhotos()
        {
            throw new NotImplementedException();
        }
    }
}
