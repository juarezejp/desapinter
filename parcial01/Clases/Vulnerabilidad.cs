using System;

namespace parcial01.Clases{
    public class Vulnerabilidad{
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private DateTime fecha;

        public Vulnerabilidad(string clave, string vendedor,string descripcion, int tipo, DateTime fecha){
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=asignarTipo(tipo);
            this.fecha=fecha;
        }
        private string asignarTipo(int t){
            string[] tipos = {"local","remota"};
            if(t>=0 && t<tipos.Length){
                return tipos[t];
            }
            else{
                return tipos[0];
            }
        }

        public string Clave{
            get{return clave;}
        }
        public string Vendedor{
            get{return vendedor;}
        }
        public string Descripcion{
            get{return descripcion;}
        }

        public string Tipo{
            get{return tipo;}
        }

        public DateTime Fecha{
            get{return fecha;}
        }
        public TimeSpan getAntiguedad(){
            return DateTime.Now-fecha;
        }  
    }
}
