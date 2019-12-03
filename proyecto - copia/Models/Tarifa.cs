using System.ComponentModel.DataAnnotations;
using System;

namespace proyecto.Models
{
    public class Tarifa{
        [Key]
        [Display(Name="ID")]
        public int IDTarifa{get;set;}
        
        [Display(Name="clase",Prompt="clase")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string clase{get;set;}  
        [Display(Name="precio",Prompt="precio")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int precio{get;set;}  
        [Display(Name="impuesto",Prompt="impuesto")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int impuesto{get;set;}  


    }
}