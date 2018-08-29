using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;
using System.ComponentModel.DataAnnotations;


namespace WWL.Models
{
    public class Account
    {
        [Key]
        public string FNUsername { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public int Status { get; set; }
        public bool LoggedIn { get; set; }
        public List<Team> Teams { get; set; }

        public Account(string fnUsername, string email, byte[] passwordHash, byte[] salt)
        {
            FNUsername = fnUsername;
            Email = email;
            PasswordHash = passwordHash;
            Salt = salt;
            LoggedIn = false;
            Teams = new List<Team>();
            Status = 0;
        }
    }
}
