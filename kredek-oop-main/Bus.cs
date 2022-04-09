namespace Object_oriented_programming
{
class Bus : Vehicle
    {
        int gasoilLevel;

        public Bus(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
        }

        /// <summary>
        /// Funkcja tankujaca bus
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus został zatankowany";
        }

        /// <summary>
        /// Implementacja metody odziedziczonej
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            return "Autobus odjezdza";
        }

        /// <summary>
        /// Implementacja metody odziedziczonej
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {
            return "Autobus sie zatrzymuje"; 
        }
   
    }
}