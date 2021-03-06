﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models.Enums;

namespace WWL.Models
{
    public class Team
    {
        public List<Player> Players { get; set; }
        public int NumPlayers { get
            {
                return Players.Count();
            }
        }
        public TeamType TeamType { get; set; }
       
        //set as Key
        public int Id { get; set; }
    }
}
