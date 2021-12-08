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
        static double Income_Tax(string income)
        {
            double proceeds;
            if (Double.TryParse(income, out proceeds))
            {
                if (proceeds < 0)
                {
                    Console.WriteLine("Dochodowy nie moga byc mniejsze od 0");
                }
                else
                {
                    if (proceeds >= 0 && proceeds <= 85528)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}\n", proceeds * 0.17);
                    }
                    else if (proceeds > 85528 && proceeds < 1000000)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}\n", 85528 * 0.17 + (proceeds - 85528) * 0.32);
                    }
                    else if (proceeds >= 1000000)
                    {
                        Console.WriteLine("Twoj podatek dochodowy wynosi: {0}\n", 85528 * 0.17 + (999999 - 85528) * 0.32 + (proceeds - 999999) * 0.36);
                    }
                }
            }
            else
            {
                Console.WriteLine("Podana została nie prawidłowa wartość, podaj liczbe calkowita !");
            }
            return proceeds;
        }
        static void Calculator(string first, string second, char char_calculator) 
        {
            int firstc, secondc;
            if (Int32.TryParse(first, out firstc) && Int32.TryParse(second, out secondc))
            {
                switch (char_calculator)
                {
                    case '+':
                        Console.WriteLine("\nWynik twojego dzialania dodawania liczb {0} i {1} to {2}", first, second, firstc + secondc);
                        break;
                    case '-':
                        Console.WriteLine("\nWynik twojego dzialania odejmowania liczb {0} i {1} to {2}", first, second, firstc - secondc);
                        break;
                    case '*':
                        Console.WriteLine("\nWynik twojego dzialania mnozenia liczb {0} i {1} to {2}", first, second, firstc * secondc);
                        break;
                    case '/':
                        if (secondc != 0)
                        {
                            Console.WriteLine("\nWynik twojego dzialania dzielenia liczb {0} i {1} to {2}", first, second, firstc / secondc);
                        }
                        else
                            Console.WriteLine("\nWynik twojego dzialania dzielenia liczb {0} i {1} nie moze zostac wykonane nie ma dzielenia przez 0", first, second);
                        break;
                    default:
                        Console.WriteLine("\nPODANO NIE PRAWIDLOWY ZNAK DZIALAN DLA KALKULATORA");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPodana została nie prawidłowa wartość którejś z liczb, podaj liczby calkowite !");
            }
        }
            static void Main(string[] args)
            {
            
             Console.WriteLine("Podaj liczbe uzyskanych procent z egzaminu:\n");
             Exam_Result(Console.ReadLine());


             Console.WriteLine("Podaj swoj dochod:\n");
             Income_Tax(Console.ReadLine());
            

            Console.WriteLine("Podaj dwie liczby CALKOWITE do kalkulatora oraz znak jakiego chcesz uzyc dzialania(+, -, *, /):\n");
            string fnumber = Console.ReadLine();
            string snumber = Console.ReadLine();
            char coperation=Console.ReadKey().KeyChar;
            Calculator(fnumber, snumber, coperation);
        }
        }
    }

