using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ResHotel.Models{
    public class BookingRoom{
        [Key]
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int GuestID { get; set; }   
        
    }
}