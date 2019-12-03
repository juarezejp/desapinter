using Microsoft.EntityFrameworkCore;
using proyecto.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace proyecto.Data
{
    public class aeropuertopCollectionContext : DbContext{
        public aeropuertopCollectionContext(DbContextOptions<aeropuertopCollectionContext> options) : base(options) 
        {
        }

        public DbSet<Aerolinea> Aerolinea{get;set;}
        public DbSet<Aeropuerto> Aeropuerto{get;set;}
        public DbSet<Asiento> Asiento{get;set;}
        public DbSet<Avion> Avion{get;set;}
        public DbSet<Pago> Pago{get;set;}
        public DbSet<Pais> Pais{get;set;}
        public DbSet<Pasajero> Pasajero{get;set;}
        public DbSet<Reserva> Reserva{get;set;}
        public DbSet<Tarifa> Tarifa{get;set;}
        public DbSet<Vuelo> Vuelo{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}