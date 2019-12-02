using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ResHotel.Models{
    public class Guest{
        [Key]
        [Display(Name="ID")]
        public int GuestID { get; set; }

        public string GuestTitle { get; set; }
        [Display(Name="Forenames",Prompt="Forenames Guest")]
        [Required(ErrorMessage="Falta el nombre")]
        public string GuestForenames { get; set; }
        [Display(Name="Surnames",Prompt="Surnames Guest")]
        [Required(ErrorMessage="Faltan los Apellidos")]
        public string GuestSurnames { get; set; }
        public DateTime GuestDOB { get; set; }
        [Display(Name="AddressStreet",Prompt="AddressStreet Guest")]
        public string GuestAddressStreet { get; set; }
        [Display(Name="AddressTown",Prompt="AddressTown Guest")]
        public string GuestAddressTown { get; set; }
        [Display(Name="County",Prompt="County Customer")]
        public string GuestAddressCountry { get; set; }
        [Display(Name="AddressPostalCode",Prompt="County Customer")]
        public string GuestAddressPostaleCode { get; set; }
        [Display(Name="ContactPhone",Prompt="ContactPhone Guest")]
        public string GuestContactPhone { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
    }
}