
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace proyecto.Data
{
    //public class aeropuertoCollectionContext : DbContext
    public class aeropuertoCollectionContext : IdentityDbContext<User>
    {
        public aeropuertoCollectionContext (DbContextOptions<aeropuertoCollectionContext> options)
            : base(options)
        {
        }


        public DbSet<proyecto.Models.Avion> Avion { get; set; }
        public DbSet<proyecto.Models.Pasajero> Pasajero { get; set; }
        public DbSet<proyecto.Models.Aeropuerto> Aeropuerto { get; set; }
        public DbSet<proyecto.Models.Pais> Pais { get; set; }
        public DbSet<proyecto.Models.Aerolinea> Aerolinea { get; set; }





    }
}
