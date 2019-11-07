using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class Rooms{
        public int RoomID {get;set;}
        public int RoomTypeID {get;set;}
        public int RoomBandID {get;set;}
        public int RoomPriceID {get;set;}

        public string Floor {get;set;}
        public string AdditionalNotes {get; set;}

        public RoomTypes roomType {get;set;}
        public RoomBands roomBand {get;set;}
        public RoomPrices roomPrice {get;set;}        
    }
}
