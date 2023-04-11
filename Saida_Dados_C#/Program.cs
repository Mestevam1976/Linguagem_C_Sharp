using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(String[] args) {

            Console.WriteLine("Bom dia!");
            Console.Write("Boa noite!");

            int x, y;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);


            CultureInfo CI = CultureInfo.InvariantCulture;// Para deixar sem influência do Regional e padrão US
            double z;
            z = 2.3456;
            Console.WriteLine(z.ToString("F2",CI)); 

            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'F';

            Console.WriteLine("A funcionária " + nome + ", sexo " + sexo + ", ganha R$ " 
                + salario.ToString("F2", CI) + " e ela tem " + idade + " anos.");
        }
    }
}


