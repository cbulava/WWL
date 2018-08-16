using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models

namespace WWL.Services
{
    public class AccountService
    {
        public Status CreateAccount(string FNUsername, string email, string password)
        {
            return new Status(true, "success");
        }

        public Status changeEmail(string email)
        {
            return new Status(true, "success");
        }

        public Status changePassword(string password)
        {
            return new Status(true, "success");
        }

        public Status changeUsername(string FNUsername)
        {
            return new Status(true, "success");
        }
    }
}
