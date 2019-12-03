namespace proyecto.Models
{
    public class Vuelo{
        public int IDAsiento{get;set;}
        public int IDAeropuerto{get;set;}
        public int IDReserva{get;set;}
        public int IDAvion{get;set;}
        public int IDTarifa{get;set;}

        public Asiento Asiento{get;set;}
        public Aeropuerto Aeropuerto{get;set;}
        public Reserva Reserva{get;set;}
        public Avion Avion{get;set;}
        public Tarifa Tarifa{get;set;}

    }
}