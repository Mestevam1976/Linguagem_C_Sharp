using System;
using System.Globalization;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, conte;

            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int [,] mat = new int [N,N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("DIAGONAN PRINCIPAL: "); 
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            conte = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        conte++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS IGUAL " + conte);
        }
    }
}
