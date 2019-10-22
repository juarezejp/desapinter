using System.Collections.Generic;

using System;

namespace dvdCollection.Models
{
    public class FilmTitles {
        public int FilmTitleID{get;set;}
        public string FilmTitle{get;set;}
        public string FilmStory{get;set;}
        public DateTime FilmRelaseDate{get;set;}
        public int FimDuration  {get;set;}
        public int FilmGenereID{get;set;}
        public int FilmCertificateID{get;set;}
        public string FilmAdditionalInfo{get;set;}

        public FilmGeneres Genere {get;set;}
        public Certificates Certificate {get;set;}

        public ICollection<FilmTitlesProducers> FilmActorRoles{get;set;}
        public ICollection<FilmsActorRoles> FilmsActorRoles{get;set;}
    }
}