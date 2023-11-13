using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.Models
{
    public class Position : IHaveId
    {
        /// <summary>
        /// Id должности
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование должности
        /// </summary>
        public string Name { get; set; }

        public Position() { }

        public Position(string Id, string Name)
        {
            this.Id = int.Parse(Id);
            this.Name = Name;   
        }

        public Position(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }
}
