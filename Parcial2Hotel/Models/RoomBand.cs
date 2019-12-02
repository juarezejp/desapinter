using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ResHotel.Models{
    public class RoomBand{
        [Key]
        [Display(Name="ID")]
        public int RoomBandID { get; set; }
        [Display(Name="Descripción")]
        public string BandDesc { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}