using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class BatteryModel
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
        public int BufferModeServiceTime { get; set; }
        /// <summary>
        /// Срок службы в циклическом режиме (число циклов)
        /// </summary>
        public int MinSoH { get; set; }
        /// <summary>
        /// Список фотографий этой модели аккумулятора
        /// </summary>
        public List<string> Photos { get; set; } = new List<string>();

        public BatteryModel() { }

        // TODO - Разобраться с назначением полей Technology и ClampType в конструкторе.
        public BatteryModel(string name, string brand, string capacity, string voltage, 
            string length, string height, string width, string technology, string clampType, string cost, 
            string bufferModeServiceTime, string minSoH, List<string> photoPaths)
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
            Photos = photoPaths;
        }
    }
}
