using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Torok_Erika_Tunde.Models;

namespace Torok_Erika_Tunde.Data
{
    public class Torok_Erika_TundeContext : DbContext
    {
        public Torok_Erika_TundeContext (DbContextOptions<Torok_Erika_TundeContext> options)
            : base(options)
        {
        }

        public DbSet<Torok_Erika_Tunde.Models.Client> Client { get; set; } = default!;

        public DbSet<Torok_Erika_Tunde.Models.Material> Material { get; set; }
    }
}
