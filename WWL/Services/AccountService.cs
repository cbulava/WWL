using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;
using WWL.Models.DBContexts;


namespace WWL.Services
{
    public class AccountService
    {
        private readonly AccountContext _accContext;

        public AccountService(AccountContext context)
        {
            _accContext = context;
        }

        public Status CreateAccount(string fnUsername, string email, string password)
        {
            //check if username already exists:
            var usernameQuery = from u in _accContext.Accounts where u.FNUsername == fnUsername select u;
            if(usernameQuery.Count() > 0)
            {
                return new Status(false, "Username is already taken");
            }

            //hash the password w/ salt
            HashingService hs = new HashingService();
            byte[] salt = hs.GenerateSalt();
            byte[] hash = hs.GenerateHashWithSalt(salt, password);

            var newAcc = new Account(fnUsername, email, hash, salt);

            try
            {
                _accContext.Accounts.Add(newAcc);
                _accContext.SaveChanges();
            }
            catch (Exception e)
            {
                return new Status(false, "Failed to create Account: " + e.Message);
            }

            return new Status(true, "success");
        }

        public Status ChangeEmail(string email)
        {
            //check if user is logged in
            

            return new Status(true, "success");
        }

        public Status ChangePassword(string password)
        {
            return new Status(true, "success");
        }

        public Status ChangeUsername(string FNUsername)
        {
            return new Status(true, "success");
        }
    }
}
