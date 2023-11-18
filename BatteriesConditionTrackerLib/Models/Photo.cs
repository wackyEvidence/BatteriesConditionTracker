using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class Photo
    {
        /// <summary>
        /// Id фотографии
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Для фотографий, уже хранящихся на диске: путь к фотографии на диске.
        /// Для фотографий, еще не загруженных на диск: путь к фотографии на компьютере.
        /// </summary>
        public string DiskFilePath { get; set; }
        public string LocalFilePath { get; set; }
    }
}
