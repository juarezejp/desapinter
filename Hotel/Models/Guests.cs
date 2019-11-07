using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class Guests{
        [Key]
        [Display(Name="ID")]
        public int GuestID {get;set;}

        [Display(Name="Title",Prompt="Title Guest")]
        [Required(ErrorMessage="El Titulo del Guest es obligatorio")]
        [StringLength(50)]
        public string GuestTitle {set;get;}
        
        [Display(Name="Forenames",Prompt="Forenames Guest")]
        [Required(ErrorMessage="El Nombre del Guests es obligatorio")]
        [StringLength(50)]
        public string GuestForenames {get;set;}

        [Display(Name="Surnames",Prompt="Surnames Guest")]
        [Required(ErrorMessage="El Apellido del Guest es obligatorio")]
        [StringLength(50)]
        public string GuestSurnames {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}", ApplyFormatInEditMode=true)]
        public DateTime GuestDOB {get;set;}

        [Display(Name="AddressStreet",Prompt="AddressStreet Guest")]
        [Required(ErrorMessage="El nombre de la calle del Guest es obligatoria")]
        [StringLength(100)]
        public string CustomerAddressStreet {get;set;}

        [Display(Name="AddressTown",Prompt="AddressTown Guest")]
        [Required(ErrorMessage="La direccion de la ciudad del Guest es obligatoria")]
        [StringLength(100)]
        public string GuestAddressTown {get;set;}

        [Display(Name="County",Prompt="County Customer")]
        [Required(ErrorMessage="El Condado del Guest es obligatoria")]
        [StringLength(100)]
        public string GuestCounty {get;set;}

        [Display(Name="AddressPostalCode",Prompt="County Customer")]
        [Required(ErrorMessage="El Condado del Guest es obligatorio")]
        [DataType(DataType.PostalCode)]
        public int GuestAddressPostalCode {get;set;}

        [Display(Name="ContactPhone",Prompt="ContactPhone Guest")]
        [Required(ErrorMessage="El Telefono del Guest es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        public string GuestHomePhone {get;set;}

        
    }
}