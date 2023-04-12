using System;
using System.Globalization;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, troca, soma;

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            soma = 0;
            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                   soma = soma + i;
                }
            }
            Console.WriteLine("A SOMA DOS NÚMEROS ÍMPARES É: " + soma);
        }
    }
}
