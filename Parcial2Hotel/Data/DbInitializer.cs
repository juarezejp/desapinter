using ResHotel.Models;
using System;
using System.Linq;
 
namespace ResHotel.Data
{
    public class DbInitializer
    {
        public static void Initializate(HotelContext context){
            context.Database.EnsureCreated();
            if(context.FacilitieLists.Any()){
                return; //la base de dats ya tiene datos 
            }

            var FacilitieList = new FacilitieList[]{
                    new FacilitieList{FacilityID=1,FacilityDesc="facilitr1"},
                    new FacilitieList{FacilityID=2,FacilityDesc="facilitr2"},
                    new FacilitieList{FacilityID=3,FacilityDesc="facilitr3"}

            };
            foreach(FacilitieList q in FacilitieList){context.FacilitieLists.Add(q);}
            context.SaveChanges();
            //Guest
            var Guest = new Guest[]{
                new Guest{GuestID=1,GuestTitle="1",GuestForenames="Carlos",GuestSurnames="Lopez",GuestDOB=DateTime.Parse("1/1/2018"),GuestAddressCountry="México",GuestAddressTown="Zacatecas",GuestAddressStreet="Insurgentes",GuestAddressPostaleCode="98000",GuestContactPhone="4987563651"},
                new Guest{GuestID=2,GuestTitle="2",GuestForenames="Manuel",GuestSurnames="Hernandez",GuestDOB=DateTime.Parse("2/2/2018"),GuestAddressCountry="México",GuestAddressTown="Zacatecas",GuestAddressStreet="Morelos",GuestAddressPostaleCode="98000",GuestContactPhone="4596878963"},
                new Guest{GuestID=3,GuestTitle="3",GuestForenames="Maria",GuestSurnames="Benitez",GuestDOB=DateTime.Parse("2/2/2018"),GuestAddressCountry="México",GuestAddressTown="Jalisco",GuestAddressStreet="Hacienda nueva",GuestAddressPostaleCode="96000",GuestContactPhone="4469878963"}
            };
            foreach(Guest u in Guest){context.Guests.Add(u);}
            context.SaveChanges();
            //Customer
            var Customer = new Customer[]{
                new Customer{CustomerID=1,CustomerTitle="1",CustomerForenames="Guadalupe",CustomerSurnames="Gonzalez",CustomerDOB=DateTime.Parse("1/1/2019"),
                    CustomerAddressCountry="España",CustomerAddressTown="España",CustomerAddressStreet="España",CustomerAddressPostalCode="1236",CustomerCustomEmail="guada@gmail.com",CustomerHomePhone="6987453210"},
                new Customer{CustomerID=2,CustomerTitle="2",CustomerForenames="Alejandro",CustomerSurnames="Betancourth",CustomerDOB=DateTime.Parse("2/2/2019"),
                    CustomerAddressCountry="USA",CustomerAddressTown="Los Angeles",CustomerAddressStreet="California",CustomerAddressPostalCode="9874",CustomerCustomEmail="alex@gmail.com",CustomerHomePhone="3698741225"},
                new Customer{CustomerID=3,CustomerTitle="3",CustomerForenames="Alicia",CustomerSurnames="Jara",CustomerDOB=DateTime.Parse("3/3/2019"),
                    CustomerAddressCountry="Mexico",CustomerAddressTown="Zacatecas",CustomerAddressStreet="Zacatecas",CustomerAddressPostalCode="98000",CustomerCustomEmail="alicia@gmail.com",CustomerHomePhone="4589632123"}

            };
            foreach(Customer i in Customer){context.Customers.Add(i);}
            context.SaveChanges();


            //Roomtypes
            var RoomType = new RoomType[]{
                new RoomType{RoomTypeID=1,RoomTypes="Individual"},
                new RoomType{RoomTypeID=2,RoomTypes="Compartido"},
                new RoomType{RoomTypeID=3,RoomTypes="Matrimonial"}
            };
            foreach(RoomType e in RoomType){context.RoomTypes.Add(e);}
            context.SaveChanges();
        
            //RoomBand
            var RoomBand = new RoomBand[]{
                new RoomBand{RoomBandID=1,BandDesc="Band1"},
                new RoomBand{RoomBandID=2,BandDesc="Band2"},
                new RoomBand{RoomBandID=3,BandDesc="Band3"}
            };
            foreach(RoomBand r in RoomBand){context.RoomBands.Add(r);}
            context.SaveChanges();
        
            //RoomPrice
            var RoomPrice = new RoomPrice[]{
                new RoomPrice{RoomPriceID=1,RoomPrices=1000},
                new RoomPrice{RoomPriceID=2,RoomPrices=1500},
                new RoomPrice{RoomPriceID=3,RoomPrices=2000}
            };
            foreach(RoomPrice t in RoomPrice){context.RoomPrices.Add(t);}
            context.SaveChanges();
        
            //Room
            var Room = new Room[]{
                new Room{RoomID=1,RoomTypeID=1,RoomBandID=1,RoomPriceID=1,Floor="1"},
                new Room{RoomID=2,RoomTypeID=2,RoomBandID=2,RoomPriceID=2,Floor="2"},
                new Room{RoomID=3,RoomTypeID=3,RoomBandID=3,RoomPriceID=3,Floor="3"}
            };
            foreach(Room y in Room){context.Rooms.Add(y);}
            context.SaveChanges();
        
            //RoomFacilitieList
            var RoomFacilitieList = new RoomFacilitieList[]{
                new RoomFacilitieList{FacilityID=1,RoomID=1,FacilityDetails="Instalacion grifo"},
                new RoomFacilitieList{FacilityID=2,RoomID=2,FacilityDetails="Regadera"},
                new RoomFacilitieList{FacilityID=3,RoomID=3,FacilityDetails="Cama"}
            };
            foreach(RoomFacilitieList w in RoomFacilitieList){context.RoomFacilitieLists.Add(w);}
            context.SaveChanges();
        
            //PaymentMethod
            var PaymentMethod = new PaymentMethod[]{
                new PaymentMethod{PaymentMethodID=1,PaymentMethods="Paypal"},
                new PaymentMethod{PaymentMethodID=2,PaymentMethods="Cheque"},
                new PaymentMethod{PaymentMethodID=3,PaymentMethods="Efectivo"}
            };
            foreach(PaymentMethod o in PaymentMethod){context.PaymentMethods.Add(o);}
            context.SaveChanges();
        
            //Booking
            var Booking = new Booking[]{
                new Booking{BookingID=1,CustomerID=1,DateBookingMade=DateTime.Parse("1/1/2019"),TimeBookingMade="dos dias", BookedStartDate=DateTime.Parse("29/2/2019"),
                    BookedEndDate=DateTime.Parse("8/2/2019"),TotalPaymentDueAmount=200,TotalPaymentDueDate=DateTime.Parse("1/3/2019"),BookingComments="Sin comentarios"},
                new Booking{BookingID=2,CustomerID=2,DateBookingMade=DateTime.Parse("2/2/2019"),TimeBookingMade="dos dias", BookedStartDate=DateTime.Parse("4/2/2019"),
                    BookedEndDate=DateTime.Parse("12/3/2019"),TotalPaymentDueAmount=400,TotalPaymentDueDate=DateTime.Parse("11/12/2019"),BookingComments="Sin comentarios"},
                new Booking{BookingID=3,CustomerID=3,DateBookingMade=DateTime.Parse("2/3/2019"),TimeBookingMade="tres dias", BookedStartDate=DateTime.Parse("5/2/2019"),
                    BookedEndDate=DateTime.Parse("10/11/2019"),TotalPaymentDueAmount=600,TotalPaymentDueDate=DateTime.Parse("4/10/2019"),BookingComments="Sin comentarios"}
            };
            foreach(Booking p in Booking){context.Bookings.Add(p);}
            context.SaveChanges();
        
            //Payment
            var Payment = new Payment[]{
                new Payment{PaymentID=1,BookingID=1,CustomerID=1,PaymentMethodID=1,PaymentAmount=200,PaymentComments="Sin comentario"},
                new Payment{PaymentID=2,BookingID=2,CustomerID=2,PaymentMethodID=2,PaymentAmount=300,PaymentComments="Sin comentario"},
                new Payment{PaymentID=3,BookingID=3,CustomerID=3,PaymentMethodID=3,PaymentAmount=200,PaymentComments="Sin comentario"}
            };
            foreach(Payment a in Payment){context.Payments.Add(a);}
            context.SaveChanges();
        
            //Bookings Room
            var BookingRoom = new BookingRoom []{
                new BookingRoom{BookingID=1,RoomID=1,GuestID=1},
                new BookingRoom{BookingID=2,RoomID=2,GuestID=2},
                new BookingRoom{BookingID=3,RoomID=3,GuestID=3}
            };
            foreach(BookingRoom s in BookingRoom){context.BookingRooms.Add(s);}
            context.SaveChanges();
        
        }
    }
}