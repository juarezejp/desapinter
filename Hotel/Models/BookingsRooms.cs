namespace Hotel.Models
{
    public class BookingsRooms
    {
        public int BookingID {get;set;}
        public int RoomID {get;set;}
        public int GuestID {get;set;}

        public Bookings Bookings {get;set;}
        public Rooms Rooms {get;set;}
        public Guests Guests {get;set;}
        
        
    }
}