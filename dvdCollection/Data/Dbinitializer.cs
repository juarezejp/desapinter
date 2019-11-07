using System.Linq;
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;
using dvdCollection.Data;
using System;

namespace dvdCollection.Data
{
    public static class DbInitializer{
        public static void Initializate(dvdCollectionContext context){
            context.Database.EnsureCreated(); //c rea un Bd si no exite

            if(context.FilmGeneres.Any()){
                return; //la base de dats ya tiene datos 

            }
            // arreglo de tipo film generes 
            var FilmGeneres = new FilmGeneres[]{
                new FilmGeneres{GenreDesc="Action"},
                new FilmGeneres{GenreDesc="Aventure"},
                new FilmGeneres{GenreDesc="Animation"},
                new FilmGeneres{GenreDesc="biograpy"},
                new FilmGeneres{GenreDesc="Comedy"},
                new FilmGeneres{GenreDesc="Crime"},
                new FilmGeneres{GenreDesc="Drama"},
                new FilmGeneres{GenreDesc="Family"},
                new FilmGeneres{GenreDesc="Fantasy"},
                new FilmGeneres{GenreDesc="History"}
            };
            foreach(FilmGeneres g in FilmGeneres){
                context.FilmGeneres.Add(g);
            }
            context.SaveChanges();

            //FilmCertificates 
            var FilmCertificates = new FilmCertificates[]{
                new FilmCertificates{FilmCertificate="G"},
                new FilmCertificates{FilmCertificate="PG"},
                new FilmCertificates{FilmCertificate="PG-13"},
                new FilmCertificates{FilmCertificate="R"},
                new FilmCertificates{FilmCertificate="NC-17"}
            };
            foreach (FilmCertificates f in FilmCertificates)
            {
                context.FilmCertificates.Add(f);

            }
            context.SaveChanges();
            
            //actors 
            var Actors = new Actors[]{
                new Actors {ActorFullName="Linda Blair",ActorNotes="From the age of five, Linda Blair had to get used to the spotlight, first as a child model and then as an actress, when out of 600 applicants she was picked for the role of Regan, the possessed child, in El exorcista (1973)."},
                new Actors {ActorFullName="Scarlett Johansson",ActorNotes="Scarlett Ingrid Johansson (Nueva York, 22 de noviembre de 1984)4​ es una actriz de cine, cantante y modelo estadounidense que alcanzó la fama con su papel en la película The Horse Whisperer (1998) y posteriormente obtuvo la aclamación por parte de los críticos de cine debido a su participación en Ghost World" },
                new Actors {ActorFullName="Keshia Knight Pulliam",ActorNotes="eshia Knight Pulliam es una actriz estadounidense. Es conocida por su papel de infancia como Rudy Huxtable, el hijo más joven de Cliff y Clair Huxtable con solo 5 a 13 años, en la comedia de la NBC The Cosby Show y como Miranda Lucas-Payne en la comedia dramática de TBS Tyler Perry's House de Payne"}
            };
            foreach (Actors a in Actors)
            {
                context.Actors.Add(a);

            }
            context.SaveChanges();
            //RoleTypes 

            var RolesTypes = new RolesTypes[]{
                new RolesTypes{RolDesc="Lead"},
                new RolesTypes{RolDesc="Principal"},
                new RolesTypes{RolDesc="Supporting"},
                new RolesTypes{RolDesc="Fetured"},
                new RolesTypes{RolDesc="Extra"}
            };

             foreach (RolesTypes r in RolesTypes)
            {
                context.RoleTypes.Add(r);
            }
            context.SaveChanges();
            //Producers 
            var Producers = new Producers[]{
                new Producers{ProducerName="Alejandro González Iñárritu",ContactEmailAddress="alegon@gmail.com",WebSite="iñarittu.com"},
                new Producers{ProducerName="Alfonso Cuarón",ContactEmailAddress="Cuaron@gmail.com",WebSite="Cuaron.com"},
                new Producers{ProducerName="Guillermo del Toro Gómez",ContactEmailAddress="guillermo@gmail.com",WebSite="gullermito.com"}
            };
            foreach (Producers pr in Producers)
            {
                context.Producers.Add(pr);
            }
            context.SaveChanges();

            //FilmTitles 
            var FilmTitles = new FilmTitles[]{
                new FilmTitles{FilmTitle="El laberinto del faulno",
                FilmCertificateID=1,FilmGenereID=1, FilmRelaseDate=DateTime.Parse("1/1/2018"),
                FilmDuration=120,FilmStory="El fauno asusta la niña" }
            };
            foreach(FilmTitles t in FilmTitles) {
                context.FilmTitles.Add(t);
            }
            context.SaveChanges(); 
        }

    }
}