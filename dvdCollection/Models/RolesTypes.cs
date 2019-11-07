using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models{
    public class RolesTypes
    {
        [Key]
        
        public int RolTypeID{get; set;}
        public string RolDesc{get; set;}
        
        public ICollection <FilmsActorRoles> FilmActorRole {get; set;}
        
    }
}