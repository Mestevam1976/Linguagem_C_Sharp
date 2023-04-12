using System;
using System.Globalization;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;

            Console.WriteLine("Digite dois números inteiros distintos: ");
            Console.WriteLine("Para encerrar a execução digite dois números inteiros iguais: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE!");                    
                }
                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIM DA EXECUÇÃO");


        }
    }
}
