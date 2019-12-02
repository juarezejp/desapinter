using ResHotel.Models;
using Microsoft.EntityFrameworkCore;
namespace ResHotel.Data
{
    public class HotelContext : DbContext
    {
         public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingRoom> BookingRooms  { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FacilitieList> FacilitieLists  { get; set; }
        public DbSet<Guest> Guests  { get; set; }
        public DbSet<Payment> Payments  { get; set; }
        public DbSet<PaymentMethod> PaymentMethods  { get; set; }   
        public DbSet<Room> Rooms  { get; set; }
        public DbSet<RoomBand> RoomBands  { get; set; }
        public DbSet<RoomFacilitieList> RoomFacilitieLists  { get; set; }
        public DbSet<RoomPrice> RoomPrices  { get; set; }
        public DbSet<RoomType> RoomTypes  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<BookingRoom>().ToTable("BookingRoom");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FacilitieList>().ToTable("FacilitieList");
            modelBuilder.Entity<Guest>().ToTable("Guest");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<RoomBand>().ToTable("RoomBand");
            modelBuilder.Entity<RoomFacilitieList>().ToTable("RoomFacilitieList");
            modelBuilder.Entity<RoomPrice>().ToTable("RoomPrice");
            modelBuilder.Entity<RoomType>().ToTable("RoomType");
        }
    }
}