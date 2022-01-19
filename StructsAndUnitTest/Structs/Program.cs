using System;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mokinys mokinys = new Mokinys();
            mokinys.Name = "Tomas";
            mokinys.LastName = "Sernas";
            mokinys.kursoPradzia = DateTime.Today.AddDays(-30);
            mokinys.kursoPabaiga = DateTime.Today.AddDays(30);

            Console.WriteLine(mokinys.Name);
            Console.WriteLine(mokinys.kursoPradzia);

            //----------------------------------------------------------------
            DateTime takenDate = new DateTime();
            DateTime taken= takenDate.AddDays(-30);
            BibliotekosKnyga bibliotekosKnyga1 = new BibliotekosKnyga(112, "A", "Jack",takenDate);
            Console.WriteLine(bibliotekosKnyga1.DaysBookAtREaders(taken));

            //------------------------------------------------------------------
        }
    }
}
