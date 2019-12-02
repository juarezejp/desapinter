using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Aerolinea{
        [Key]
        [Display(Name="ID")]
        public int IDAerolinea{get;set;}
        [Display(Name="ruc",Prompt="Registro Único de Contribuyente")]
        [Required(ErrorMessage="El ruc es obligatorio")]
        public int ruc{get;set;}

        
    }
}