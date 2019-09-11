using System;
using parcial01.Clases;

namespace parcial01{
    class Program{
        static void Main(string[] args){
            //red
            Red r = new Red("Red Patito, S.A. de C.V.", "Mr Pato Macdonald","Av. Princeton 123, Orlando Florida");
            //crear vulnerabilidades
            Vulnerabilidad v1 = new Vulnerabilidad("CVE-2015-1635","micrsoft","HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario", 0,new DateTime(2015,04,14));
            Vulnerabilidad v2 = new Vulnerabilidad("CVE-2017-0004","micrsoft","El servicio LSASS permite causar una denegación de servicio", 1,new DateTime(2015,1,10));
            Vulnerabilidad v3 = new Vulnerabilidad(" CVE-2017-3847","cisco"," Cisco Firepower Management Center XSS", 0,new DateTime(2017,02,21));
            Vulnerabilidad v4 = new Vulnerabilidad("CVE-2009-2504","micrsoft"," Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", 1,new DateTime(2009,11,13));
            Vulnerabilidad v5 = new Vulnerabilidad("CVE-2016-7271","micrsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold", 0,new DateTime(2016,12,20));
            Vulnerabilidad v6 = new Vulnerabilidad("CVE-2017-2996","micrsoft","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable", 1,new DateTime(2015,04,14));
            //crear nodos
            Nodo n1 = new Nodo("192.168.0.10",0,5,10,"linux");
            Nodo n2 = new Nodo("192.168.0.12",1,2,12,"ios");
            Nodo n3 = new Nodo("192.168.0.20",2,8,5,"windows");
            Nodo n4 = new Nodo("192.168.0.15",0,10,22,"linux");
            //insertar vulnerabilidades
            n1.insertaVulnerabilidades(v1);
            n1.insertaVulnerabilidades(v2);
            n2.insertaVulnerabilidades(v3);
            n3.insertaVulnerabilidades(v4);
            n3.insertaVulnerabilidades(v5);
            n3.insertaVulnerabilidades(v6);
            //insertar nodos
            r.insertarNodo(n1);
            r.insertarNodo(n2);
            r.insertarNodo(n3);
            r.insertarNodo(n4);
            //salida
            Console.WriteLine(">>Datos generales de la red:\n");
            Console.WriteLine($"Empresa   :{r.Empresa}");
            Console.WriteLine($"Propietario   :{r.Propietario}");
            Console.WriteLine($"Domicilio   :{r.Domicilio}\n");
            
            Console.WriteLine($"Mayor numero de saltos: {r.getMayorSalto()}");
            Console.WriteLine($"Menor numero de saltos: {r.getMenorSalto()}\n");

            Console.WriteLine(">>Datos generales de los nodos:\n");

            foreach(Nodo n in r.Nodos){
                Console.WriteLine($"IP: {n.Ip}, Tipo: {n.Tipo}, Puertos: {n.Puertos  }, Saltos: {n.Saltos}, SO: {n.So}, TotVul: {n.getTotalVulnerabilidades()}");
            }

            Console.WriteLine(">>Vulnerabilidades por nodo:\n");
            foreach(Nodo n in r.Nodos){
                Console.WriteLine($"> Ip: {n.Ip}, Tipo: {n.Tipo}\n");
                Console.WriteLine("Vulnerabilidades:\n");
                if(n.Vulnerabilidades.Count>0){
                    foreach(Vulnerabilidad v in n.Vulnerabilidades){
                        Console.WriteLine($"Clave: {v.Clave}, Vendedor: {v.Vendedor}, Descripción: {v.Descripcion}, Tipo: {v.Tipo}, Fecha: {v.Fecha.ToString("d")}, Antigüedad:{v.getAntiguedad().Days} dias");
                    }
                }                 
                else{
                    Console.WriteLine("No tiene vulnerabilidades ...");
                    }
                Console.WriteLine();
            }

        }
    }
}
