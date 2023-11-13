using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    internal interface IHavePhotos
    {
        public List<string> Photos { get; set; }
        public List<string> GetPhotos(); 
        public void SavePhotos(); 
        public void DeletePhotos(); 
    }
}
