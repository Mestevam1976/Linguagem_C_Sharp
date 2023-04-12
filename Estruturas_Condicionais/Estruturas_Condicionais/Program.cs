using System;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.Write("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());
            if (hora >= 5 && hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18) 
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
