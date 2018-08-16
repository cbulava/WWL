using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace WWL.Models
{
    public class Tournament
    {
        public Tournament(string name, [Range(8, 32768)] int size = 0) { 
            Size = size;
            Teams = new List<Team>(size);
            Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Size { get; set; }
        public TeamType TournamentType { get; set; }
        public List<Team> Teams { get; set; }

    }
}
