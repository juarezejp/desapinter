using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class FacilitiesList{
        [Key]
        [Display(Name="ID")]
        public int FacilityList {get;set;}

        [Display(Name="FacilityDesc",Prompt="FacilityDesc")]
        [Required(ErrorMessage="El FacilityDesc es obligatorio")]
        [StringLength(50)]
        public string FacilityDesc {get;set;}


        public ICollection<LINK_RoomsFacilities> LINK_RoomsFacilities {get;set;}
    }
}
