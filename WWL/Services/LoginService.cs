using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;
using WWL.Models.DBContexts;

namespace WWL.Services
{
    public class LoginService
    {
        private readonly AccountContext _accContext;

        public LoginService(AccountContext context)
        {
            _accContext = context;
        }

        public Status Login(string fnUsername, string password)
        {
            //check if username exists
            var acc = _accContext.Accounts.Find(fnUsername);
            if (acc == null)
                return new Status(false, "Username does not exist");

            //check if password is correct
            HashingService hs = new HashingService();
            byte[] hash = hs.GenerateHashWithSalt(acc.Salt, password);
            if(hash != acc.PasswordHash)
            {
                return new Status(false, "Password was incorrect");
            }

            //set Logged in status
            acc.LoggedIn = true;
            _accContext.Accounts.Attach(acc);
            _accContext.Entry(acc).Property(x => x.LoggedIn).IsModified = true;
            _accContext.SaveChanges();

            return new Status(true, "success");
        }

        public Status Logout(string fnUsername)
        {
            try
            {
                //get acc
                var acc = _accContext.Accounts.Find(fnUsername);
                acc.LoggedIn = false;

                //set logged in status
                acc.LoggedIn = true;
                _accContext.Accounts.Attach(acc);
                _accContext.Entry(acc).Property(x => x.LoggedIn).IsModified = true;
                _accContext.SaveChanges();
            }
            catch(Exception e)
            {
                return new Status(false, "Error logging out. Please contact the system admin with the error message" + e.Message);
            }

            return new Status(true, "success");
        }
    }
}
