using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            double b;
            long c;
            
            while (true){
                Console.WriteLine("Введiть змiнну типу int:");
                try {
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
            }

            while (true)
            {
                Console.WriteLine("Введiть змiнну типу double:");
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
            }

            while (true)
            {
                Console.WriteLine("Введiть змiнну типу long:");
                try
                {
                    c = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Було введено некоректне значення!");
                }
            }
            
            Console.WriteLine($"a = {a}; b = {b}; c = {c}");

        }
    }
}
