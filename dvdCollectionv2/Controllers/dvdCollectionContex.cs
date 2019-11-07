using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Controllers
{
    public class dvdCollectionContex : DbContext{
        public dvdCollection(DbContextOptions<dvdCollectionContex> options):base(options){

        }
        public DbSer<Actors> Actors {get;set;}
        public DbSer<Certificates> Certificates {get;set;}
        public DbSer<FilmGeneres> FilmGeneres {get;set;}
        public DbSer<FilmsActorRoles> FilmsActorRoles {get;set;}
        public DbSer<FilmTitles> FilmTitles {get;set;}
        public DbSer<FilmTitlesProducers> FilmTitlesProducers {get;set;}
        public DbSer<Producers> Producers {get;set;}
        public DbSer<RoleTypes> RoleTypes {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<FilmTitlesProducers>().HasKey(c => new {c.ProducersID, c.FilmTitlesID});
            modelBuilder.Entity<FilmsActorRoles>().HasKey(c => new {c.FilmTitleID, c.ActorID, c.RoleTypeID});
        
        }
    }
}
