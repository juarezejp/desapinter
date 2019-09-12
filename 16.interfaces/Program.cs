using System;
using _16.interfaces.Clases;
using System.Collections.Generic;


namespace _16.interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caja> costal=LlenarCostal();
            Caja miCaja = new Caja("Roja", true, "Calzones",10,20);
            Console.WriteLine("Ejemplo de interfaces\n");
            costal.Add(miCaja);
            foreach(Caja c in costal){
                Console.WriteLine($"Color: {c.Color} \nEstatus: {(c.EstaAbierta?"Abierta":"Cerrada")} \nContenido: {(c.EstaAbierta?c.Contenido:"nel")}");
                Console.WriteLine($"Dimensiones: {c.Medidas()}\n");
            }
            
        }

        static List<Caja> LlenarCostal(){
            List<Caja> todo = new List<Caja>();
            todo.Add(new Caja("Rojo",false,"Manzanas",10,10));
            todo.Add(new Caja("Verde",false,"Mariguana",10,10));
            todo.Add(new Caja("Azul",false,"Nubes",10,10));
            todo.Add(new Caja("Negro",false,"Carbon",10,10));
            todo.Add(new Caja("Blanca",false,"Manzanas",10,10));
            todo.Add(new Caja("Rosa",false,"Flores",10,10));
            return todo;
        }

    }
}
