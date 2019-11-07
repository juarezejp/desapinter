using System;
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

            // FilmCertificates
            var FilmCertificates = new FilmCertificates[] {
                new FilmCertificates {FilmCertificate="G"},
                new FilmCertificates {FilmCertificate="PG"},
                new FilmCertificates {FilmCertificate="PG-13"},
                new FilmCertificates {FilmCertificate="R"},
                new FilmCertificates {FilmCertificate="NC-17"}
            };
            foreach(FilmCertificates f in FilmCertificates) {
                context.FilmCertificates.Add(f);
            }
            context.SaveChanges(); 

            //actores
            var Actors = new Actors[] {
                new Actors{ActorFullName="Linda Blair", ActorNotes="algoskdjfkjdkfjklasj;kldjf"},
                new Actors{ActorFullName="Scarlett Johansson", ActorNotes="dfoskdjfkjdkfjklasj;kldjf"},
                new Actors{ActorFullName="Kesia ", ActorNotes="dhsjfkasoskdjfkjdkfjklasj;kldjf"}
            };
            foreach(Actors a in Actors){
                context.Actors.Add(a);
            }
            context.SaveChanges();

            //RoleTypes
            var RoleTypes = new RoleTypes[] {
                new RoleTypes{RoleDesc="Lead"},
                new RoleTypes{RoleDesc="Principal "},
                new RoleTypes{RoleDesc="Supportin"},
                new RoleTypes{RoleDesc="Featured"},
                new RoleTypes{RoleDesc="Extra"}
            };
            foreach(RoleTypes r in RoleTypes){
                context.RoleTypes.Add(r);
            }
            context.SaveChanges();

             // Producers
            var Producers = new Producers[] {
                new Producers {ProducerName="Alejandro González Iñárritu",ContactEmailAddress="alegon@gmail.com",WebSite="http://alegon.com"},
                new Producers {ProducerName="Alfonso Cuarón",ContactEmailAddress="cuaron@yahoo.com",WebSite="http://cuaron.tv   "},
                new Producers {ProducerName="Guillermo del Toro",ContactEmailAddress="deltoro@gmail.com",WebSite="http://deltoro.com"},
            };
            foreach(Producers p in Producers) {
                context.Producers.Add(p);
            }
            context.SaveChanges(); 
            // FilmTitles
            var FilmTitles = new FilmTitles[] {
                new FilmTitles {FilmTitle="El laberinto del fauno",
                FilmCertificateID=1, FilmGenereID=1, FilmRelaseDate=DateTime.Parse("1/1/2010"),
                FilmDuration=120, FilmStory="El fauno asusta la niña" }
            };
            foreach(FilmTitles t in FilmTitles) {
                context.FilmTitles.Add(t);
            }
            context.SaveChanges(); 
        }
    }
} 