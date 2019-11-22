using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Bookings
    {
        [Key]
        [Display(Name="ID")]
        public int BookingID { get; set;}
        
        public int CustomerID {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime DateBookingMade {get;set;}
   
        public int TimeBookingMade {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime BookedStartDate {get;set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime BookedEndDate {get;set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode=false)]
        public DateTime TotalPaymentDueDate {get;set;}
        
        public double TotalPaymentDueAmount {get;set;}
        public double totalPaymentMadeOn {get;set;}
        public string BookingComments {get;set;}

        
        public Customers Customers {get;set;}

        public ICollection<BookingsRooms> BookingsRooms {get;set;}
        public ICollection<Payments> Payments {get;set;}

    }
}