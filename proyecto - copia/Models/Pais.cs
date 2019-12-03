using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Pais{
        [Key]
        [Display(Name="ID")]
        public int IDPais{get;set;}

        [Display(Name="nombre",Prompt="Nombre del pais")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string nombre{get;set;}    
    }
}