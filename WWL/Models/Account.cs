using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;

namespace WWL.Models
{
    public class Account
    {
        public string FNUsername { get; set; }
        public string Email { get; set; }
        private string _password { get; set; }
        public string Password { get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public int Id { get; set; }

        public int Status { get; set; }

        public bool LoggedIn { get; set; }

        public List<Team> Teams { get; set; }
    }
}
