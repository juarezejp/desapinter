using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dvdCollection.Models
{
    public class FilmsActorRoles

    {
        public int FilmTitleID{get; set;}
        public int ActorID{get; set;}
        public int RoleTypeID{get; set;}
         [Display(Name="Name",Prompt="Nombre del personaje")]
        [Required(ErrorMessage="El nombre del personaje es obligatorio")]
        [StringLength(80)]
        public string CharacterName{get; set;}
        [Display(Name="Description",Prompt="Descripcion del personaje")]
        [Required(ErrorMessage="La descripcion del personaje es obligatoria")]
        [StringLength(60)]
        public string CharacterDescription {get; set;}

        public Actors actor{get; set;}
        public RolesTypes Role{get; set;}
        public FilmTitles filmTitle {get; set;}

        
    }
}