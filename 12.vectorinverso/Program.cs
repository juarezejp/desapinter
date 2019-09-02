using System;

namespace _12.vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int [15];
            int[] vr = new int [15];

            Random rnd = new Random();
            
            for(int i=0; i<v.Length; i++){
                v[i] = rnd.Next(1,50);
                vr[v.Length-i-1] = v[i];
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
