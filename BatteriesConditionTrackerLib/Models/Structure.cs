using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class Structure
    {
        /// <summary>
        /// Id объекта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип объекта
        /// </summary>
        public StructureType Type { get; set; }
    }
}
