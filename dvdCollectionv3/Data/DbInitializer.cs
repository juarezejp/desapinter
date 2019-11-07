using System.Linq;
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Data 
{
    public static class DbInitializer {
        public static void Initializate(dvdCollectionContext context) {
            context.Database.EnsureCreated(); // crea bd si no existe

            if(context.FilmGeneres.Any()) {
                return; // la bd ya tiene datos
            }

            // arreglo del tipo FilmGeneres 
            var FilmGeneres = new FilmGeneres[] {
                new FilmGeneres {GenereDesc="Action"},
                new FilmGeneres {GenereDesc="Aventure"},
                new FilmGeneres {GenereDesc="Animation"},
                new FilmGeneres {GenereDesc="Biography"},
                new FilmGeneres {GenereDesc="Comedy"},
                new FilmGeneres {GenereDesc="Crime"},
                new FilmGeneres {GenereDesc="Drama"},
                new FilmGeneres {GenereDesc="Family"},
                new FilmGeneres {GenereDesc="Fantasy"},
                new FilmGeneres {GenereDesc="History"}
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(FilmGeneres g in FilmGeneres) {
                context.FilmGeneres.Add(g);
            }
            //grabar los datos en la bd fisica
            context.SaveChanges();      
        }
    }
} 