using System;

namespace Lab4
{
    class Program
    {
        static double CalculateCirclePole(int R)
        {
            double Pole;
            Console.WriteLine($"Pole kola to: {Pole=Math.Round(Math.Pow(R,2)* Math.PI,2)}");
            return Pole;
        }
        static bool JakiRok (int rok)
        {
            if (rok % 4 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            CalculateCirclePole(3);
            JakiRok(2004);
        }
    }
}
