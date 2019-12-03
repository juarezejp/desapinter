using System.ComponentModel.DataAnnotations;
using System;

namespace proyecto.Models
{
    public class Reserva{
        [Key]
        [Display(Name="ID")]
        public int IDReserva{get;set;}
        
        [Display(Name="costo",Prompt="costo")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int costo{get;set;}  
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime fecha { get; set;}
        [Display(Name="nombre",Prompt="Nombre del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int observacion{get;set;}  

    }
}