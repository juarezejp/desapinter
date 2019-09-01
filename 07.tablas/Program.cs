using System;

namespace _07.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            tablaespecifica();

            Console.WriteLine("Hasta cual tabla deseas imprimir");
            int tabdes=int.Parse(Console.ReadLine());
            Console.WriteLine("Hasta cual numero deseas imprimir");
            int numdes=int.Parse(Console.ReadLine());
            tabladeseada(tabdes, numdes);

        }

        static void tabladeseada(int tabdes, int numdes){
            for(int i=1; i<=tabdes;i++){
                for(int j=1; j<=numdes;j++){
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine("");
            }
        }
        static void tablaespecifica(){
            for(int i=1; i<=10; i++){
                Console.WriteLine($"7 * {i} = {7*i}");
            }
        }
    }
}
