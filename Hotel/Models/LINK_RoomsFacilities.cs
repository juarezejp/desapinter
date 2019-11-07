using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class LINK_RoomsFacilities{
        public int RoomID {get;set;}
        public int FacilityID {get;set;}
        [Display(Name="FacilityDetails",Prompt="FacilityDetails")]
        [Required(ErrorMessage="FacilityDetails  obligatorio")]
        [StringLength(60)]
        public string FacilityDetails {get;set;}

        public FacilitiesList facilitiesList {get;set;}
        public Rooms rooms {get;set;}

    }
}
