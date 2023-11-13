using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.TextHelper
{
    /// <summary>
    /// Extension-методы для работы TextConnector. 
    /// </summary>
    public static class TextHelper
    {
        /// <summary>
        /// Составляет полный путь к соответствующему файлу, используя указанную пользователем директорию из настроек приложения.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Полный путь к файлу с именем fileName</returns>
        public static string GetFullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["textFilesPath"]}\\{fileName}";
        }
        /// <summary>
        /// Загружает файл, который лежит по указанному пути. 
        /// </summary>
        /// <param name="filePath">Полный путь к файлу</param>
        /// <returns>Список всех строк файла</returns>
        public static List<string> LoadFile(this string filePath)
        {
            if(!File.Exists(filePath))
                return new List<string>(); 
            
            return File.ReadAllLines(filePath).ToList();
        }
        /// <summary>
        /// Преобразует список строк в список моделей.
        /// </summary>
        /// <typeparam name="T">Тип модели</typeparam>
        /// <param name="lines">Список строк</param>
        /// <param name="modelCreation">Делегат создания модели из массива значений строки файла</param>
        /// <returns>Список моделей типа Т</returns>
        public static List<T> ConvertToModels<T>(this List<string> lines, Func<string[], T> modelCreation)
        {
            var positionModels = new List<T>();

            foreach(var line in lines)
            {
                var columns = line.Split(',');
                positionModels.Add(modelCreation(columns));
            }

            return positionModels;
        }
        /// <summary>
        /// Сохраняет список моделей типа Т в текстовый файл. 
        /// </summary>
        /// <typeparam name="T">Тип модели</typeparam>
        /// <param name="models">Список моделей типа Т</param>
        /// <param name="fileName">Имя файла, в который нужно сохранить информацию</param>
        /// <param name="modelToCSV">Делегат преобразования модели в строку</param>
        public static void SaveToTextFile<T>(this List<T> models, string fileName, Func<T, string> modelToCSV)
        {
            var lines = new List<string>();

            foreach (var model in models)
                lines.Add(modelToCSV(model));

            File.WriteAllLines(fileName.GetFullFilePath(), lines);
        }
    }
}
