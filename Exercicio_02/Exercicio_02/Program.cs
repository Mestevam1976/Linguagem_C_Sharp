using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.WriteLine("Informe os dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine(nome1 + " tem " + idade1 + " anos e " + nome2 + " tem " + idade2 + " anos e a média de idade entre eles é de " 
              + media.ToString("F1", CI) + " anos.");
        }
    }
}
