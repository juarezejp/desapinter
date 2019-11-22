using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class RoomPrices{
        [Key]
        [Display(Name="ID")]
        public int RoomPriceID {get;set;}

        [Display(Name="BandDesc",Prompt="BandDesc")]
        [Required(ErrorMessage="El BandDesc es obligatorio")]
        public double RoomPrice {get;set;}

        public ICollection<Rooms> Rooms {get;set;}
    }
}
