using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    public class BatteryModel
    {
        /// <summary>
        /// Id модели аккумулятора
        /// </summary>
        public int Id { get; set; }
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
        public double Length { get; set; }
        /// <summary>
        /// Высота аккумулятора (мм)
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Ширина аккумулятора (мм)
        /// </summary>
        public double Width { get; set; }
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
        public int CycleModeServiceTime { get; set; }
        /// <summary>
        /// Список фотографий этой модели аккумулятора
        /// </summary>
        public List<string> Photos { get; set; } = new List<string>(); 
    }
}
