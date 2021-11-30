using System;

namespace JakubPiekarek_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby: \n");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine($"A najwieksze - {a}");
                }
                else
                {
                    Console.WriteLine($"C najwieksze - {c}");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"B najwieksze - {b}");
                }
                else
                {
                    Console.WriteLine($"C najwieksze - {c}");
                }
            }

        }
    }
}
