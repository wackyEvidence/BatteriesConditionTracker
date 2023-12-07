using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

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

        public static readonly Func<string[], Structure> ModelCreation = columns => new Structure(columns);
        public static readonly Func<Structure, string> ModelToCSV = structure => $"{structure.Id},{structure.Name},{structure.Type.Id}";

        public Structure() { }

        public Structure(string[] columns)
        {
            // TO DO Как и в остальных конструкторах 
            Id = int.Parse(columns[0]); 
            Name = columns[1];
            Type = GlobalConfig.Connection.GetStructureType_ById(int.Parse(columns[2]));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
