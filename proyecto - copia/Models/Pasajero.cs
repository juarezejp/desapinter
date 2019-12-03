using System.ComponentModel.DataAnnotations;
using System;


namespace proyecto.Models
{
    public class Pasajero{
        [Key]
        [Display(Name="ID")]
        public int IDPasajero{get;set;}

        [Display(Name="nombre",Prompt="Nombre del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string nombre{get;set;}  
        [Display(Name="apaterno",Prompt="apellido paterno del pasajero")]
        public string apaterno{get;set;}
        [Display(Name="amaterno",Prompt="apellido materno del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string amaterno{get;set;}
        [Display(Name="tipo_documento",Prompt="tipo documento del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public string tipo_documento{get;set;}
        [Display(Name="num_documento",Prompt="num documento del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int num_documento{get;set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime fecha_nacimiento { get; set;}

        public int IDPais{get;set;}
        public Pais Pais{get;set;}

        [Display(Name="telefono",Prompt="Telefono del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int telefono{get;set;}
        [Display(Name="email",Prompt="email del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        [EmailAddress]
        public string email{get;set;}
        [Display(Name="clave",Prompt="clave del pasajero")]
        [Required(ErrorMessage="Campo obligatorio")]
        public int clave{get;set;}
    }
}