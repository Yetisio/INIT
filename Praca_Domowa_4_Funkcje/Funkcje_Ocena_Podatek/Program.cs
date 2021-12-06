using System;

namespace Funkcje_Ocena_Podatek
{
    class Program
    {
        static void Exam_Result(string percent)
        {
            int percentage;
            if (Int32.TryParse(percent, out percentage))
            {
                if (percentage >= 0 && percentage <= 100)
                {
                    if (percentage >= 0 && percentage <= 30)
                    {
                        Console.WriteLine("Twoja ocena z egzaminu to DWÓJKA");
                    }
                    else if (percentage > 30 && percentage <= 70)
                    {
                        Console.WriteLine("Twoja ocena z egzaminu to TRÓJKA");
                    }
                    else if (percentage > 70 && percentage <= 90)
                    {
                        Console.WriteLine("Twoja ocena z egzaminu to CZWÓRKA");
                    }
                    else if (percentage > 90 && percentage <= 99)
                    {
                        Console.WriteLine("Twoja ocena z egzaminu to PIĄTKA");
                    }
                    else if (percentage == 100)
                    {
                        Console.WriteLine("Twoja ocena z egzaminu to SZÓSTKA");
                    }
                }
                else
                    Console.WriteLine("Liczba nie miesci sie w zakresie od 0 do 100");
            }
            else
            {
                Console.WriteLine("Podana została nie prawidłowa wartość, podaj liczbe calkowita !");
            }
        }
        static int Income_Tax(string income)
        {
            int proceeds;
            if (Int32.TryParse(income, out proceeds))
            {
                if (proceeds < 0)
                {
                    Console.WriteLine("Dochodowy nie moga byc mniejsze od 0");
                }
                else
                {
                    if (proceeds >= 0 && proceeds <= 85528)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}", proceeds * 0.17);
                    }
                    else if (proceeds > 85528 && proceeds < 1000000)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}", proceeds * 0.32);
                    }
                    else if (proceeds >= 1000000)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}", proceeds * 0.32 + proceeds * 0.04);
                    }
                }
            }
            else
            {
                Console.WriteLine("Podana została nie prawidłowa wartość, podaj liczbe calkowita !");
            }
            return proceeds;
        }
            static void Main(string[] args)
            {
             Console.WriteLine("Podaj liczbe uzyskanych procent z egzaminu:\n");

             Exam_Result(Console.ReadLine());


             Console.WriteLine("Podaj swoj dochod:\n");

             Income_Tax(Console.ReadLine());

            }
        }
    }

