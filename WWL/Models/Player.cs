using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WWL.Models
{
    public class Player
    {
        public string FNUsername { get; set; }
        [Key]
        public int AccountId { get; set; }
    }
}
