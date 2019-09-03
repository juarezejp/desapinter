using System;
using ControlBancario.Clases;

namespace ControlBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria micuenta1 = new CuentaBancaria();
            CuentaBancaria micuenta2 = new CuentaBancaria(1000);
            CuentaDeAhorros miahorro = new CuentaDeAhorros(600,0.3);
            CuentaDeCheques micheque = new CuentaDeCheques(5000, 1000);


            micuenta1.Deposita(300);
            micuenta2.Retira(500);
            miahorro.Deposita(100);
            miahorro.Retira(50);
            micheque.Deposita(3000);
            micheque.Retira(9000);

            Console.WriteLine($"cuenta 1 : {micuenta1.Saldo}");
            Console.WriteLine($"cuenta 2 : {micuenta2.Saldo}");
            Console.WriteLine($"cuenta 3 : {miahorro.Saldo}");
            Console.WriteLine($"cuenta 4 : {micheque.Saldo}");



        }


    }
}
