using System.Collections.Generic; 
using System;

namespace parcial01.Clases{
    public class Nodo{
        private string ip;
        private string tipo;
        private int puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidad> vulnerabilidades;

        public Nodo(string ip, int numtipo, int puertos, int saltos, string so){
            this.ip=ip;
            this.tipo=asignaTipo(numtipo);
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        private string asignaTipo(int t){
            string[] tipos={"servidor    ","equipoactivo","computadora "};
            if(t>=(0) && t<tipos.Length ) {return tipos[t];}
            else{
                return tipos[0];
            }
        }
        public void insertaVulnerabilidades(Vulnerabilidad v){
            vulnerabilidades.Add(v);
        }
        public string Ip{
            get{return ip;}
        }
        public string Tipo{
            get{return tipo;}
        }
        public int Puertos{
            get{return puertos;}
        }
        public int Saltos{
            get{return saltos;}
        }
        public string So{
            get{return so;}
        }
        public int getTotalVulnerabilidades(){
            return vulnerabilidades.Count;
        }
        public List<Vulnerabilidad>Vulnerabilidades{
            get{return vulnerabilidades;}
        }
    }
}