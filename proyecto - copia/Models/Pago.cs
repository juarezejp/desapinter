using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace proyecto.Models
{
    public class Pago{
        [Key]
        [Display(Name="ID")]
        public int IDPago{get;set;}
        public int IDReserva{get;set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime fecha { get; set;}
        
        public int IDPasajero{get;set;}

        [Display(Name="monto",Prompt="monto")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int monto{get;set;}
        [Display(Name="tipo",Prompt="tipo_comprobante")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string tipo_comprobante{get;set;}
        [Display(Name="num_comprobante",Prompt="num_comprobante")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int num_comprobante{get;set;}
        [Display(Name="impuesto",Prompt="impuesto")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int impuesto{get;set;}

        public Reserva Reserva{get;set;}
        public Pasajero Pasajero{get;set;}

    }
}
