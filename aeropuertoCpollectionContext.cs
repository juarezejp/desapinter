using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace Proyecto.Data
{
    public class aeropuertoCpollectionContext : DbContext
    {
        public aeropuertoCpollectionContext (DbContextOptions<aeropuertoCpollectionContext> options)
            : base(options)
        {
        }

        public DbSet<proyecto.Models.Pasajero> Pasajero { get; set; }
    }
}
