
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Aeropuerto
    {
        [Key]
        [Display(Name="ID")]
        public int IDAeropuerto{get;set;}
        [Display(Name="Nombre",Prompt="Nombre del Aeropuerto")]
        [Required(ErrorMessage="El ruc es obligatorio")]
        public string nombre{get;set;}

        public int IDPais{get;set;}

        public Pais Pais{get;set;}
          
    }
}