using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

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

        public static readonly Func<string[], StructureType> ModelCreation = columns => new StructureType(columns);
        public static readonly Func<StructureType, string> ModelToCSV = structureType => $"{structureType.Id},{structureType.Name}";


        public StructureType() { }

        public StructureType(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }
}
