using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Jakub_Piekarek_Zadanie_Domowe
{
    class Program
    {
		static void Main()
		{
			string imie;
			Console.Write("Podaj imie: ");
			imie = Console.ReadLine();
			char plec;
			Console.Write("\nPodaj plec (m to mezczyzna, k to kobieta): ");
			plec =char.Parse(Console.ReadLine());
			int wiek;
			Console.Write("\nPodaj swoj wiek: ");
			wiek =int.Parse(Console.ReadLine());
			float wzrost;
			Console.Write("\nPodaj wzrost: ");
			wzrost =float.Parse(Console.ReadLine());
			double waga;
			Console.Write("\nPodaj wage: ");
			waga = double.Parse(Console.ReadLine());
			string plec2;
			if (plec == 'm')
			{
				plec2 = "mezczyzna";
			}
			else
			{
				plec2 = "kobieta";
			}
			Console.Clear();
			Console.Write("Masz na imie ");
			Console.Write(imie);
			Console.Write(" plec twoja to: ");
			Console.Write(plec2);
			Console.Write(", wzrost: ");
			Console.Write(wzrost);
			Console.Write(", waga: ");
			Console.Write(waga);
			Console.Write("\n");


		}
	}
}
