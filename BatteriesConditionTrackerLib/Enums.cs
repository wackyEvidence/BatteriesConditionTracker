using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    public enum FormMode
    {
        Adding, 
        Editing
    }

    public enum DatabaseType
    {
        SqlServer, 
        TextFile, 
        PostgreSql
    }
}
