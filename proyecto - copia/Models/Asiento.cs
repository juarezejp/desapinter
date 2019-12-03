using System.ComponentModel.DataAnnotations;


namespace proyecto.Models
{
    public class Asiento{
        [Key]
        [Display(Name="ID")]
        public int IDAsiento{get;set;}
        [Display(Name="letra",Prompt="Letra del asiento")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string letra{get;set;}
        [Display(Name="fila",Prompt="Fila del asiento")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string fila{get;set;}

    }
}