using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.DataAccess;
using BatteriesConditionTrackerLib.DataAccess.Interfaces;
using BatteriesConditionTrackerLib.Models;
using Dapper;

namespace BatteriesConditionTrackerLib
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static User CurrentUser { get ; set; }

        private static Dictionary<string, DatabaseType> dbTypeMap = new Dictionary<string, DatabaseType>()
        {
            { "TextFiles", DatabaseType.TextFiles },
            { "SqlServer", DatabaseType.SqlServer },
            { "PostgreSQL", DatabaseType.PostgreSql }
        };

        public static void InitializeConnection()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

                if(dbTypeMap[settings["dbType"].Value] != DatabaseType.TextFiles)
            {
                var columnMaps = new Dictionary<string, string>()
                {
                    { "id", "Id" }, 
                    { "name", "Name" },
                    { "surname", "Surname" },
                    { "patronymic", "Patronymic" }, 
                    { "phone_number", "PhoneNumber" },
                    { "email", "Email" },
                    { "password", "Password" }, 
                    { "is_admin", "IsAdmin" }
                };

                var mapper = new Func<Type, string, PropertyInfo>((type, columnName) =>
                {
                    if (columnMaps.ContainsKey(columnName))
                        return type.GetProperty(columnMaps[columnName]);
                    else
                        return type.GetProperty(columnName);
                });

                var userMap = new Dapper.CustomPropertyTypeMap(
                    typeof(User),
                    (type, columnName) => mapper(type, columnName)); 
                Dapper.SqlMapper.SetTypeMap(typeof(User), userMap); 
            }

            switch (dbTypeMap[settings["dbType"].Value])
            {

                case DatabaseType.SqlServer:
                    var sqlConnector = new SqlConnector();
                    Connection = sqlConnector; 
                    break;
                case DatabaseType.TextFiles:
                    var textConnector = new TextConnector(); 
                    Connection = textConnector;
                    break;
                case DatabaseType.PostgreSql:
                    var postgreConnector = new PostgreConnector();
                    Connection = postgreConnector;
                    break;
                default:
                    throw new Exception("Invalid connection type!");
            }
        }

        public static string GetConnectionString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
