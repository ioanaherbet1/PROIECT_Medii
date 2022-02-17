using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Herbet_Ioana_ONG.Models;

namespace Herbet_Ioana_ONG.Data
{
    public class Herbet_Ioana_ONGContext : DbContext
    {
        public Herbet_Ioana_ONGContext (DbContextOptions<Herbet_Ioana_ONGContext> options)
            : base(options)
        {
        }

        public DbSet<Herbet_Ioana_ONG.Models.Voluntar> Voluntar { get; set; }

        public DbSet<Herbet_Ioana_ONG.Models.Departament> Departament { get; set; }

        public DbSet<Herbet_Ioana_ONG.Models.Category> Category { get; set; }
    }
}
