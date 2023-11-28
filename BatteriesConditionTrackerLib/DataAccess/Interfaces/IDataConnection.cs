using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IDataConnection : ICreateData, IUpdateData, IDeleteData, IGetData_All, IGetData_ById, IGetAuthData
    {
    }
}
