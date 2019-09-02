using System;

namespace _13.vectormultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int [10];
            int[] B = new int [10];
            int[] C = new int [10];
            Random rnd = new Random();
            
            for(int i=0; i<A.Length; i++){
                A[i] = rnd.Next(1,30);
                B[B.Length-1-i] = rnd.Next(1,30);
                C[i] = A[i]*B[B.Length-1-i];
            }

            Console.WriteLine("vector A");
            imprime(A);
            Console.WriteLine("\nvector B");
            imprime(B);
            Console.WriteLine("\nvector C");
            imprime(C);
        }

        static void imprime(int[] v){
             for(int i=0; i<v.Length; i++){
                 Console.Write($"{v[i]} ");
             }
        }
    }
}
