using System;
using System.Globalization;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c, menor;

            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                menor = a;
            } 
            else if (b < c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }

            Console.WriteLine("O menor valor digitado é " + menor);
        }
    }
}
