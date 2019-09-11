using System.Collections.Generic; 


namespace parcial01.Clases
{
    public class Red
    {
        private string empresa;
        private string propietario;
        private string domicilio;
        private List<Nodo> nodos;

        public Red(string empresa, string propietario, string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            nodos = new List<Nodo>();
        }

        public void insertarNodo(Nodo n){
            nodos.Add(n);
        }
        public string Empresa{
            get{return empresa;}
        }
        public string Propietario{
            get{return propietario;}
        }
        public string Domicilio{
            get{return domicilio;}
        }
        public List<Nodo> Nodos{
            get{return nodos;}
        }
        public int getTotalNodos(){
            return nodos.Count;
        }
        public int getTotalVulnerabilidadesRed(){
            int r =0;
            foreach(Nodo n in nodos){
                r+=n.getTotalVulnerabilidades();
            }
            return r;
        }

        public int getMayorSalto(){
            int s=-1;
            if(nodos.Count>0){
                foreach(Nodo n in nodos){
                    if(s<n.Saltos) s=n.Saltos;
                }
            }
            return s;
        }

        public int getMenorSalto(){
            int s=-1;
            if(nodos.Count>0){
                s=getMayorSalto();
                foreach(Nodo n in nodos){
                    if(s>n.Saltos) s=n.Saltos;
                }
            }
            return s;
        }

    }
}