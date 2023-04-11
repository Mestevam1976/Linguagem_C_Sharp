using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;
            double b1, b2, h, area, z;

            x = 10;
            y = 20;
            z = 2 * x;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;

            area = (b1 + b2) / 2.0 * h;

            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2",CI));
            Console.WriteLine("As medidas do trapézio são: " +
                "\nbase menor = " + b1.ToString("F2",CI) + 
                " \nbase maior = " + b2.ToString("F2",CI) +
                " \naltura = " + h.ToString("F2",CI) + 
                " \nA área do trapézio é " + area.ToString("F2", CI));
        }
    }
}
