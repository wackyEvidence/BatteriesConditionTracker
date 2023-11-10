﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.DataAccess;

namespace BatteriesConditionTrackerLib
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnection(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.SQL:
                    var sqlConnector = new SqlConnector();
                    Connection = sqlConnector; 
                    break;
                case DatabaseType.TextFile:
                    var textConnector = new TextConnector(); 
                    Connection = textConnector;
                    break;
                case DatabaseType.PostgreSQL:
                    var postgreConnector = new PostgreConnector();
                    Connection = postgreConnector;
                    break;
                default:
                    break;
            }
        }

        public static string GetConnectionString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
