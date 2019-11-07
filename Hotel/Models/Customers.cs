using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class Customers{
        [Key]
        [Display(Name="ID")]
        public int CustomerID {get;set;}

        [Display(Name="Title",Prompt="Title Customer")]
        [Required(ErrorMessage="El Titulo del Customer es obligatorio")]
        [StringLength(50)]
        public string CustomerTitle {set;get;}

        [Display(Name="Forenames",Prompt="Forenames Customer")]
        [Required(ErrorMessage="El Nombre del Customer es obligatorio")]
        [StringLength(50)]
        public string CustomerForenames {get;set;}

        [Display(Name="Surnames",Prompt="Surnames Customer")]
        [Required(ErrorMessage="El Apellido del Customer es obligatorio")]
        [StringLength(50)]
        public string CustomerSurnames {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}", ApplyFormatInEditMode=true)]
        public DateTime CustomerDOB {get;set;}

        [Display(Name="AddressStreet",Prompt="AddressStreet Customer")]
        [Required(ErrorMessage="El nombre de la calle del Customer es obligatoria")]
        [StringLength(100)]
        public string CustomerAddressStreet {get;set;}

        [Display(Name="AddressTown",Prompt="AddressTown Customer")]
        [Required(ErrorMessage="La direccion de la ciudad del Customer es obligatoria")]
        [StringLength(100)]
        public string CustomerAddressTown {get;set;}

        [Display(Name="County",Prompt="County Customer")]
        [Required(ErrorMessage="El Condado del Customer es obligatoria")]
        [StringLength(100)]
        public string CustomerCounty {get;set;}

        [Display(Name="AddressPostalCode",Prompt="County Customer")]
        [Required(ErrorMessage="El Condado del Customer es obligatorio")]
        [DataType(DataType.PostalCode)]
        public int CustomerAddressPostalCode {get;set;}

        [Display(Name="HomePhone",Prompt="HomePhone Customer")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerHomePhone {get;set;}

        [Display(Name="AddressWorkPhone",Prompt="WorkPhone Customer")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerWorkPhone {get;set;}

        [Display(Name="MobilePhone",Prompt="MobilePhone Customer")]
        [Required(ErrorMessage="El Telefono del Customer es obligatoria")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerMobilePhone {get;set;}

        [Display(Name="Email",Prompt="Email Customer")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail {get;set;}

        
    }
}
