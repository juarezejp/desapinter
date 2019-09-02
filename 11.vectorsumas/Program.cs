using System;

namespace _11.vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int [30];

            Random rnd = new Random();
            int nc=0, nn=0, np=0;
            int snn=0, snp=0;

            for(int i=0; i<v.Length; i++){
                v[i] = rnd.Next(-30,30);
                if(v[i] == 0){
                    nc++;
                }
                else if(v[i]<0){
                    nn++;
                    snn+=v[i];
                }
                else{
                    np++;
                    snp+=v[i];
                }
            }
            imprime(v);
            Console.Write($"\ncantidad de ceros {nc} \n");
            Console.Write($"cantidad de negativos {nn} \n");
            Console.Write($"cantidad de positivos {np} \n");
            Console.Write($"suma de negativos {snn} \n");
            Console.Write($"suma de positivos {snp} \n");
        }

        static void imprime(int[] v){
             for(int i=0; i<v.Length; i++){
                 Console.Write($"{v[i]} ");
             }
        }
    }
}
