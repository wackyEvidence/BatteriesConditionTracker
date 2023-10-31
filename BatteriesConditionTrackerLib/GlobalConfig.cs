using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.DataAccess;

namespace BatteriesConditionTrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); 

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                var connector = new SqlConnector(); 
                Connections.Add(connector);
            }

            if (textFiles)
            {
                var connection = new TextConnector(); 
                Connections.Add(connection);
            }
        }
    }
}
