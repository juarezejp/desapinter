using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models{
    public class Room{
        [Key]
        [Display(Name="ID")]
        public int RoomID { get; set; }
        [Display(Name="RoomTypeID")]
        public int RoomTypeID { get; set; }
        [Display(Name="RoomBandID")]
        public int RoomBandID { get; set; }
        [Display(Name="RoomPriceID")]
        public int RoomPriceID { get; set; }
        [Display(Name="Piso")]
        [StringLength(100)]
        public string Floor { get; set; }
        [Display(Name="Additional Notes")]
        [StringLength(100)]
        public string AdditionalNotes { get; set; }
        public ICollection<RoomFacilitieList> RoomFacilitieLists { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
    }
}