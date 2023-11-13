using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class StructureType : IHaveId
    {
        /// <summary>
        /// Id типа объекта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование типа объекта
        /// </summary>
        public string Name { get; set; }

        public StructureType() { }

        public StructureType(string id, string name)
        {
            Id = int.Parse(id);
            Name = name; 
        }

        public StructureType(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }
}
