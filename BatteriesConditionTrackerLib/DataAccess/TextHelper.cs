using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.TextHelper
{
    public static class TextHelper
    {
        public static string GetFullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["textFilesPath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string filePath)
        {
            if(!File.Exists(filePath))
                return new List<string>(); 
            
            return File.ReadAllLines(filePath).ToList();
        }

        public static List<Position> ConvertToPositionModels(this List<string> lines)
        {
            var positionModels = new List<Position>();

            foreach(var line in lines)
            {
                var columns = line.Split(',');
                positionModels.Add(new Position(columns[0], columns[1])); 
            }

            return positionModels;
        }

        public static void SaveToPositionsFile(this List<Position> positionModels, string fileName)
        {
            var lines = new List<string>();

            foreach (var model in positionModels)
                lines.Add($"{model.Id},{model.Name}");

            File.WriteAllLines(fileName.GetFullFilePath(), lines);
        }
    }
}
