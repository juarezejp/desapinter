using System;

namespace _10.vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] v = new int [20];
            int[] vr = new int [20];

            Random rnd = new Random();
            
            for(int i=0; i<v.Length; i++){
                v[i] = rnd.Next(1,30);
                vr[i] = (int)(Math.Pow(v[i],3));
            }
            Console.WriteLine("vector original");
            imprime(v);
            Console.WriteLine("\nvector resultante");
            imprime(vr);
        }

        static void imprime(int[] v){
             for(int i=0; i<v.Length; i++){
                 Console.Write($"{v[i]} ");
             }
        }

    }
}
