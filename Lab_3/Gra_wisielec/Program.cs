using System;
using System.Collections.Generic;

namespace Gra_wisielec
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> marki_samochodow = new List<string>(); //dodanie listy z haslami
            marki_samochodow.Add("audi");
            marki_samochodow.Add("bmw");
            marki_samochodow.Add("citroen");
            marki_samochodow.Add("dacia");
            marki_samochodow.Add("fiat");
            marki_samochodow.Add("ford");
            marki_samochodow.Add("hyundai");
            marki_samochodow.Add("kia");
            marki_samochodow.Add("mercedes");
            marki_samochodow.Add("nissan");
            marki_samochodow.Add("opel");
            marki_samochodow.Add("peugeot");
            marki_samochodow.Add("renault");
            marki_samochodow.Add("seat");
            marki_samochodow.Add("skoda");
            marki_samochodow.Add("voyota");
            marki_samochodow.Add("volkswagen");
            marki_samochodow.Add("volvo");
            Random r = new Random();
            string losowe_haslo = marki_samochodow[r.Next(marki_samochodow.Count)]; //przypisanie losowego elementu z listy do stringa
            List<char> litery_hasla = new List<char>(); //dodanie listy z literami hasla
            char[] tablica = losowe_haslo.ToCharArray(); //przypisanie stringa do tablicy charowej
            //przypisanie liter do tablicy i dodanie ich do listy
            for (int i = 0; i < tablica.Length; i++)
            {
                litery_hasla.Add(tablica[i]);
                
            }
            Console.WriteLine("Twoja kategoria hasla to:  marka samochodowa");
            char[] blurowanie = tablica;
            for (int i = 0; i < tablica.Length; i++)
            {
                blurowanie[i] = '#';
            }
            
            List<char> litery_prob = new List<char>(); // lista do liter ktore wpisuje uzytkownik

            char[,] rys= new char[6,6];

            int zycia=10;
            int warunek_petla = 0;
            do
            {
                Console.WriteLine(blurowanie);
                //proba zgadniecia
                Console.WriteLine("\nPodaj litere, do zgadniecia hasla: ");
                char litera = char.Parse(Console.ReadLine());
                litery_prob.Add(litera);


                //poprawienie umozliwajace wpisania malych i duzy liter jako jedno 
                int xd = Convert.ToInt32(litera);
                if (xd >= 65 && xd <= 90)
                {
                    xd += 32;
                }
                char pom = Convert.ToChar(xd);
                litery_prob.Add(pom);
                litera = pom;


                //trafienie                
                //zamiana X na litere 
                bool sprawdzanie = litery_hasla.Contains(litera);
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (sprawdzanie == true && litera == litery_hasla[i])
                    {
                        for (int j = 0; j < tablica.Length; j++)
                        {

                            blurowanie[i] = litera;

                        }
                        warunek_petla++;
                    }

                }
                //pudlo
                

                if (sprawdzanie == false)
                {
                    zycia--;
                }
                Console.Clear();
                //rysowanie warunki
                

                if (zycia == 9)
                {
                    rys[0, 5] = '(';
                }
                if (zycia == 8)
                {
                    rys[1, 5] = ')';
                }
                if (zycia == 7)
                {
                    rys[0, 4] = '|';
                    rys[0, 3] = '|';
                    rys[0, 2] = '|';
                    rys[0, 1] = '|';
                    rys[0, 0] = '┌';
                }
                if (zycia == 6)
                {
                    rys[1, 0] = '─';
                    rys[2, 0] = '─';
                    rys[3, 0] = '─';
                    rys[4, 0] = '¬';
                    rys[1, 1] = ' ';
                    rys[1, 2] = ' ';
                    rys[1, 3] = ' ';
                    rys[1, 4] = ' ';
                    rys[2, 1] = ' ';
                    rys[2, 2] = ' ';
                    rys[2, 3] = ' ';
                    rys[2, 4] = ' ';
                    rys[2, 5] = ' ';
                    rys[3, 1] = ' ';
                    rys[3, 2] = ' ';
                    rys[3, 3] = ' ';
                    rys[3, 4] = ' ';
                }
                if (zycia == 5)
                {
                    rys[4, 1] = '|';
                }
                if (zycia == 4)
                {
                    rys[4, 2] = 'O';
                }
                if (zycia == 3)
                {
                    rys[4, 3] = '|';
                }
                if (zycia == 2)
                {
                    rys[3, 3] = '/';
                }
                if (zycia == 1)
                {
                    rys[5, 3] = ')';
                }
                if (zycia == 0)
                { 
                    rys[4, 4] = '^';
                    
                }
                //pokazywanie rysowania


                for(int w = 0; w < 6; w++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        Console.Write(rys[k, w]);
                    }
                    Console.WriteLine();
                }
            } while (zycia > 0 && warunek_petla<tablica.Length);
            if (warunek_petla == tablica.Length)
                Console.WriteLine("Koniec gry, UDALO CI SIE !\nTwoim haslem bylo {0}", losowe_haslo);
            else
                Console.WriteLine("Koniec gry, NIESTETY NIE UDALO CI SIE !\nTwoim haslem bylo {0}", losowe_haslo);
        }
    }
}
