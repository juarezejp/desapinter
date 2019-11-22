using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Payments
    {
        [Key]
        [Display(Name="ID")]
        public int PaymentID {get;set;}

        public int BookingID {get;set;}
        public int CustomerID {get;set;}
        public int PaymentMethodID {get;set;}

        public double PaymentAmount {get;set;}
        [Display(Name="PaymentComments",Prompt="PaymentComments")]
        [Required(ErrorMessage="El PaymentComments es obligatorio")]
        [StringLength(50)]
        public string PaymentComments {get;set;}

        public Bookings Bookings {get;set;}
        public Customers Customers {get;set;}
        public PaymentMethods PaymentMethods {get;set;}
    }
}