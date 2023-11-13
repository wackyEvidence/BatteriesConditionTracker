using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class Structure : IHaveId
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

        public Structure() { }

        public Structure(string[] columns)
        {
            // TO DO Как и в остальных конструкторах 
            Id = int.Parse(columns[0]); 
            Name = columns[1];
            Type = new StructureType() { Id = int.Parse(columns[2]) };
        }
    }
}
