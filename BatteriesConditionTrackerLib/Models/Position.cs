using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

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

        public static readonly Func<string[], Position> ModelCreation = columns => new Position(columns);
        public static readonly Func<Position, string> ModelToCSV = position => $"{position.Id},{position.Name}";


        public Position() { }

        public Position(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];
        }
    }
}
