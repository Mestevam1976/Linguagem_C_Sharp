using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, area, perimetro, diagonal;

            Console.WriteLine("Base do Retângulo: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Altura do Retângulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("ÁREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

        }
    }
}
