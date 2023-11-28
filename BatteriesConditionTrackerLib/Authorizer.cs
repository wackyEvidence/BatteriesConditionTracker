using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteriesConditionTrackerLib
{
    public static class Authorizer
    {
        public static bool Authorize(string login, string password)
        {
            var user = GlobalConfig.Connection.GetUser_ByLogin(login);

            if (user == null || !BCrypt.Net.BCrypt.EnhancedVerify(password, user.Password))
                return false; 

            GlobalConfig.CurrentUser = user;
            return true;
        }
    }
}
