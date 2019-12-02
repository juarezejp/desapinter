using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models{
    public class Customer{
        [Key]
        [Display(Name="ID")]
        public int CustomerID { get; set; }
        [Display(Name="Titulo")]
        public string CustomerTitle { get; set; }
        [Display(Name="Forenames",Prompt="Forenames Customer")]
        [Required(ErrorMessage="El Nombre del Customer es obligatorio")]
        [StringLength(50)]
        public string CustomerForenames { get; set; }
        [Display(Name="Surnames",Prompt="Surnames Customer")]
        [Required(ErrorMessage="El Apellido del Customer es obligatorio")]
        [StringLength(50)]
        public string CustomerSurnames { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}", ApplyFormatInEditMode=true)]
        public DateTime CustomerDOB { get; set; }
        [Display(Name="Direccion")]
        public string CustomerAddressStreet { get; set; }
        [Display(Name="Town")]
        public string CustomerAddressTown { get; set; }
        [Display(Name="County",Prompt="County Customer")]
        public string CustomerAddressCountry { get; set; }
        [Display(Name="Codigo Postal")]
        public string CustomerAddressPostalCode { get; set; }
        [Display(Name="Telefono de casa")]
        public string CustomerHomePhone { get; set; }
        [Display(Name="AddressWorkPhone",Prompt="WorkPhone Customer")]
        public string CustomerWorkPhone { get; set; }
        [Display(Name="MobilePhone",Prompt="MobilePhone Customer")]
        public string CustomerMobilPhone { get; set; }
        [Display(Name="Email",Prompt="Email Customer")]
        public string CustomerCustomEmail { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}