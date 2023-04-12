using System;
using System.Globalization;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double soma, media;

            Console.WriteLine("Quantos números você vai digitar?");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine(  );
            Console.Write("VALORES = ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();

            soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            Console.WriteLine("SOMA IGUAL A " + soma.ToString("F2", CI));

            media = soma / N;

            Console.WriteLine("A MÉDIA É IGUAL A " + media.ToString("F2", CI));
        }
    }
}
