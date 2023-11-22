using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models.Interfaces
{
    internal interface IHavePhotos
    {
        /// <summary>
        /// Хранит фото, отображаемые на форме
        /// </summary>
        public List<Photo> DisplayedPhotos { get; set; }
        /// <summary>
        /// Хранит фото, добавленные пользователем в процессе создания/редактирования модели
        /// </summary>
        public List<Photo> AddedPhotos { get; set; }
        /// <summary>
        /// Хранит фото, удаленные пользователем в процессе создания/редактирования модели
        /// </summary>
        public List<Photo> DeletedPhotos { get; set; }
        //public List<string> GetPhotos(); 
        //public void SavePhotos(); 
        //public void DeletePhotos(); 
    }
}
