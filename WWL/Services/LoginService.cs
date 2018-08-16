using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;

namespace WWL.Services
{
    public class LoginService
    {
        public Status Login(string account, string password)
        {
            return new Status(true, "success");
        }

        public Status Logout(string account)
        {
            return new Status(true, "success");
        }
    }
}
