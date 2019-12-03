using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace dvdCollection.Data
{
    public class dvdCollectionContext : DbContext
    {
        public dvdCollectionContext (DbContextOptions<dvdCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<proyecto.Models.Aeropuerto> Aeropuerto { get; set; }
    }
}
