namespace Object_oriented_programming
{
    abstract public class Vehicle
    {
        // Numer pojazdu i rok produkcji i nazwa
        protected int vehicleNumber;
        protected int yearOfProduction;
        protected string name;



        //Funckja pobierajaca numer pojazdu
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }

        //Funkcja pobierajaca rok produkcji
        public virtual int GetYearOfProduction()
        {
            return yearOfProduction;
        }

        //Metoda pobierajaca nazwe
        public virtual string GetName()
        {
            return name;
        }

        //Metoda ustawiajaca nr pojazdu
        public virtual void SetVehicleNumber(int n)
        {
            vehicleNumber = n;
        }


        
        //Metody abstrakcyjne do zdefiniowania w klasach-dzieciach!!
        abstract public string StartVehicle();
        abstract public string StopVehicle();
    }
}