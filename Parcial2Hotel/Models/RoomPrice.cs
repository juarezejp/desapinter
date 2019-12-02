using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models{
    public class RoomPrice{
        [Key]
        [Display(Name="ID")]
        public int RoomPriceID { get; set; }
        [Display(Name="Precio")]
        public int RoomPrices { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}