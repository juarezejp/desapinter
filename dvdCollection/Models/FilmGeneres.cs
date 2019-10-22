using System.Collections.Generic;

namespace dvdCollection.Models
{
    public class FilmGeneres
    {
        public int GenereTypeID{get;set;}
        public string GenereDesc{get;set;}

        public ICollection<FilmTitles> FilmTitles{get;set;}       
    }
}