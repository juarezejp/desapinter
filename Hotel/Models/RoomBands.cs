using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class RoomBands{
        [Key]
        [Display(Name="ID")]
        public int RoomBandID {get;set;}

        [Display(Name="BandDesc",Prompt="BandDesc")]
        [Required(ErrorMessage="El BandDesc es obligatorio")]
        [StringLength(50)]
        public string BandDesc {get;set;}
    }
}