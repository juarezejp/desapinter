using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Data
{
    public class DbInitializer{
        public static void Initializate(aeropuertoCollectionContext context) {
            context.Database.EnsureCreated(); // crea bd si no existe

            if(context.Pasajero.Any()) {
                return; // la bd ya tiene datos
            }

            //pasajeros
            var pasajeros = new Pasajero[]{
                new Pasajero{nombre="Luis",apaterno="Perez",amaterno="Gonzalez",tipo_documento="tipo1",num_documento=2,fecha_nacimiento=DateTime.Parse("3/11/1990")},
                new Pasajero{nombre="Ramiro",apaterno="Carrillo",amaterno="Ramirez",tipo_documento="tipo2",num_documento=3,fecha_nacimiento=DateTime.Parse("4/12/1995")},
                new Pasajero{nombre="Manuel",apaterno="Mesa",amaterno="Garcia",tipo_documento="tipo1",num_documento=4,fecha_nacimiento=DateTime.Parse("3/3/1985")},

            };
            foreach(Pasajero p in pasajeros){
                context.Pasajero.Add(p);
            }
            context.SaveChanges();

            //aeropuertos
            var Aeropuertos = new Aeropuerto[]{
                new Aeropuerto{nombre="Aeropuerto internacional de Zacatecas"},
                new Aeropuerto{nombre="Aeropuerto internacional de Aguascalientes"},
                new Aeropuerto{nombre="Aeropuerto internacional de Guadalajara"},

            };
            foreach(Aeropuerto a in Aeropuertos){
                context.Aeropuerto.Add(a);
            }
            context.SaveChanges();

            //aviones
            var Aviones = new Avion[]{
                new Avion{fabricante="Triumph Group Mexico", tipo="General", capacidad=100},
                new Avion{fabricante="Volaris", tipo="Privado", capacidad=50},
                new Avion{fabricante="Boeing", tipo="General", capacidad=150},

            };
            foreach(Avion a in Aviones){
                context.Avion.Add(a);
            }
            context.SaveChanges();

        }

    }
}