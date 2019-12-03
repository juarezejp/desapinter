using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Avion{
        [Key]
        [Display(Name="ID")]
        public int IDAvion{get;set;}
        public int IDAerolinea{get;set;}
        [Display(Name="fabricante",Prompt="Fabricante del avion")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string fabricante{get;set;}

        [Display(Name="tipo",Prompt="Tipo de avion")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string tipo{get;set;}
        [Display(Name="capacidad",Prompt="Capacidad del avion")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int capacidad{get;set;}

        public Aerolinea Aerolinea{get;set;}
    }
}