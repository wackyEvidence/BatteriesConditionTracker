using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib.DataAccess.Interfaces
{
    public interface IGetAuthData
    {
        public User GetUser_ByLogin(string login); 
    }
}
