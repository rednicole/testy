using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Calculator
    {
        public static double a = 0;
        public static double b = 0;
        public static double c = 0;

        public static void calculate()
        {
            Console.WriteLine("Jakie działanie chcesz wykonać?");
            int choose = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = Console.Read();
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = Console.Read();
                        c = a + b;
                        Console.WriteLine("Wynik to: {1} ", c);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = Console.Read();
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = Console.Read();
                        c = a - b;
                        Console.WriteLine("Wynik to: {1} ", c);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = Console.Read();
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = Console.Read();
                        c = a * b;
                        Console.WriteLine("Wynik to: {1} ", c);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = Console.Read();
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = Console.Read();
                        c = a / b;
                        Console.WriteLine("Wynik to: {1} ", c);
                        break;

                    }
            }
        }
    }
}
