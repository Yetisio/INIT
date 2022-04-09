namespace Object_oriented_programming
{
    class Tram : Vehicle, IPantograph
    {
        bool pantographIsDown;


        /// <summary>
        /// Konsturktor tramwaju, przypisanie wartosc pol z argumentow i ustawienie domyslnie pantografu na opuszczon
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Tram(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            pantographIsDown = false;
        }

        /// <summary>
        /// Deklaracja metod z interefejsu IPantograph
        /// </summary>
        /// <returns></returns>
        public string PantographDown()
        {
            if (!pantographIsDown)
            {
                pantographIsDown = true;
                return "Opuszczono pantograf";
            }
            else
            {
                return "Pantgraf jest juz opuszczony";
            }
        }

        public string PantographUp()
        {
            if (pantographIsDown)
            {
                pantographIsDown = false;
                return "Podniesiono pantograf";
            }
            else
            {
                return "Pantograf jest juz podniesiony.";
            }
        }

        /// <summary>
        /// Dzwonienie tramwaju
        /// </summary>
        /// <returns></returns>
        public string Bell()
        {
            return "Tramwaj dzwoni!";
        }

        /// <summary>
        /// Implementacja metody odizedziczonej po klasie Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            if (!pantographIsDown)
                return "Tramwaj odjeżdża.";
            else
                return "Najpierw rozłóż pantograf.";
        }

        public override string StopVehicle()
        {
            return "Tramwaj sie zatrzymuje";
        }

    }
}