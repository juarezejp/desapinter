using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models{
    public class RoomFacilitieList{
        [Key]
        [Display(Name="RoomID")]
        public int RoomID { get; set; }
        [Display(Name="FacilityID")]
        public int FacilityID { get; set; }
        [Display(Name="Detalles")]
        public string FacilityDetails { get; set; }
    }
}