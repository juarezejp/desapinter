using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models{
    public class FacilitieList{
        [Key]
        [Display(Name="ID")]
        public int FacilityID { get; set; }
        [Display(Name="FacilityDesc",Prompt="FacilityDesc")]
        [Required(ErrorMessage="El FacilityDesc es obligatorio")]
        public string FacilityDesc { get; set; }
        public ICollection<RoomFacilitieList> RoomFacilitieLists { get; set; }
    }
}