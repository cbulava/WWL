using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWL.Models;
using Microsoft.EntityFrameworkCore;

namespace WWL.Models.DBContexts
{
    public class TournamentContext : DbContext
    {
        public TournamentContext(DbContextOptions<TournamentContext> options) : base(options) { }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
