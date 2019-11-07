using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Producers {
        [Key]
        [Display(Name="ID")]
        public int ProducerID {get; set;}
        [Display(Name="Name",Prompt="Nombre completo del actor")]
        [Required(ErrorMessage="El nombre del actor es obligatorio")]
        [StringLength(80)]
        public string ProducerName {get; set;}
        [Display(Name="Email",Prompt="Correo Electronico del productor")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmailAddress {get; set;}
        [DataType(DataType.Url)]
        public string WebSite {get; set;}

        public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
    }
}