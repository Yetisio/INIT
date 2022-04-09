using System;

namespace Object_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus newBus1 = new Bus(1, 2003, "DFS231");
            Bus newBus2 = new Bus(2, 2019, "OPQ9939");

            Console.WriteLine($"Mamy autobus, którego model to {newBus1.GetName()}, wyprodukowany w roku {newBus1.GetYearOfProduction()} i posiadający numer {newBus1.GetVehicleNumber()}");
            Console.WriteLine($"Mamy autobus, którego model to {newBus2.GetName()}, wyprodukowany w roku {newBus2.GetYearOfProduction()} i posiadający numer {newBus2.GetVehicleNumber()}");
        

            Vehicle vehicle1 = new Tram(3, 2012, "EHG2223");

            Console.WriteLine($"Mamy tramwaj, którego model to {vehicle1.GetName()}, wyprodukowany w roku {vehicle1.GetYearOfProduction()} i posiadający numer {vehicle1.GetVehicleNumber()}");


            // Pokazać ten przykład
            // Vehicle vehicle2 = new Vehicle();

            // ==============ZADANIE===================
            // Zrobić zadanie na punkt dla 10 pierwszych osób aby zrobili kolejną klasę która dziedziczy po klasie Vehicle i nadpisuje bazowe metody i aby stworzyć nowy obiekt tej klasy
            // ========================================

            // Dodawanie nowego pojazdu
            Vehicle createdVehicle = CreateNewVehicle();
            // Wyświetlenie jego szczegółowych informacji
            GetVehicleInfo(createdVehicle);

            if(createdVehicle != null)
            {
                Console.WriteLine(createdVehicle.StartVehicle());
                Console.WriteLine(createdVehicle.StopVehicle());
            }

            // Pokazać blok try catch
            // try {
            //     Console.WriteLine(createdVehicle.StartVehicle());
            //     Console.WriteLine(createdVehicle.StopVehicle());
            // }
            // catch(Exception) {
            //     Console.WriteLine("Niestety ale nie jest to ani autobus ani tramwaj");
            // }

            if(createdVehicle is Tram)
            {
                Tram tram = (Tram)createdVehicle;
                Console.WriteLine(tram.PantographDown());

                Console.WriteLine("Tramwaj jedzie");

                Console.WriteLine(tram.PantographUp());

            }
            else {
                Console.WriteLine("Autobus nie ma pantografu");
            }

        }

        public static Vehicle CreateNewVehicle()
        {
            Console.WriteLine("Jaki pojazd dodać? Tramwaj czy Bus? [t/b]");
            var vehicleType = Console.ReadLine();
            Console.WriteLine("Podaj numer pojazdu:");
            var vehicleNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rok produkcji pojazdu:");
            var vehicleYearOfProduction = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj model pojazdu:");
            var vehicleName = Console.ReadLine();
            
            Vehicle newVehicle;

            switch(vehicleType) {
                case "t":
                    newVehicle = new Tram(vehicleNumber, vehicleYearOfProduction, vehicleName);
                break;
                case "b":
                    newVehicle = new Bus(vehicleNumber, vehicleYearOfProduction, vehicleName);
                break;
                default:
                    newVehicle = null;
                break;
            }

            return newVehicle;
        }

        public static void GetVehicleInfo(Vehicle vehicle)
        {
            if(vehicle is Bus)
            {
                Console.WriteLine($"Jest to autobus o nazwie {vehicle.GetName()}, wyprodukowany w {vehicle.GetYearOfProduction()} roku i posiada numer {vehicle.GetVehicleNumber()}");
                Bus bus = (Bus)vehicle;
                Console.WriteLine(bus.Refuel());
            }
            else if(vehicle is Tram)
            {
                Console.WriteLine($"Jest to tramwaj o nazwie {vehicle.GetName()}, wyprodukowany w {vehicle.GetYearOfProduction()} roku i posiada numer {vehicle.GetVehicleNumber()}");
                Tram tram = (Tram)vehicle;
                Console.WriteLine(tram.Bell());
            }
            else {
                Console.WriteLine("Niestety ale nie jest to ani tramwaj ani autobus");
            }
        }



    }
}
