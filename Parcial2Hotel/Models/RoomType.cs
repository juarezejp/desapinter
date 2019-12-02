using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ResHotel.Models{
    public class RoomType{   
        [Key]
        [Display(Name="ID")]
        public int RoomTypeID { get; set; }
        [Display(Name="RoomType",Prompt="RoomType")]
        public string RoomTypes { get; set; }
        
        public ICollection<Room> Rooms { get; set; }
    }
}