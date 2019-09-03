
namespace ControlBancario.Clases{

    public class CuentaDeAhorros : CuentaBancaria{
        private double tasa;

        public CuentaDeAhorros(double saldo, double tasa) 
            :base(saldo){
            
            this.tasa=tasa;
        }

    }


}