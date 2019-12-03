using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Data
{
    public class aeropuertoCollectionContext : DbContext
    {
        public aeropuertoCollectionContext (DbContextOptions<aeropuertoCollectionContext> options)
            : base(options)
        {
        }


        public DbSet<proyecto.Models.Avion> Avion { get; set; }
        public DbSet<proyecto.Models.Pasajero> Pasajero { get; set; }
        public DbSet<proyecto.Models.Aeropuerto> Aeropuerto { get; set; }





    }
}
