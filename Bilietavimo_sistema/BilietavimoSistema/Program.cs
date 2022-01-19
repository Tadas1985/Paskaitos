using System;

namespace BilietavimoSistema
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    bool isAlive = true;
        //    int ticketAmount = 0;
        //    int sukurtiBilietai10, sukurtiBilietai20, sukurtiBilietai30;
        //    int createdTicketsAmount = 0;
        //    int pasirinkimas =0;
        //    while (isAlive)
        //    {
        //        Console.WriteLine("[1]-Pirkti bilietus, [2]- Kurti bilietus ");
        //        pasirinkimas = Convert.ToInt32(Console.ReadLine());

        //        switch (pasirinkimas)
        //        {
        //            case 1:
        //                PirktiBilietus();
        //                break;
        //            case 2:
        //                KurtiBilietus();
        //                break ;
        //            default:
        //                break;
        //        }
        //    }
        //}

        //public static void KurtiBilietus()
        //{
        //    Console.WriteLine("Pasirinkite bilieto tipa: [1]-Po 10 E, [2]-Po 20E, [3]-Po 30E");
        //    int bilietoTipas = Convert.ToInt32((Console.ReadLine()));
        //    switch (bilietoTipas)
        //    {
        //        case 1:
        //            int sukurtiBilietai10 = AmountOfTickets(bilietoTipas, 10);
        //            break;
        //        case 2:
        //            int sukurtiBilietai20 = AmountOfTickets(bilietoTipas, 20);
        //            break;
        //        case 3:
        //            int sukurtiBilietai30= AmountOfTickets(bilietoTipas, 30);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public static void PirktiBilietus()
        //{
        //    Console.WriteLine("Pasirinkite perkamo bilieto tipa: [1]-Po 10 E, [2]-Po 20E, [3]-Po 30E");
        //    int bilietoTipas = Convert.ToInt32((Console.ReadLine()));
        //    Console.WriteLine($"Pasirinkite bilieto {bilietoTipas} kieki");
        //    int ticketAmount = Convert.ToInt32((Console.ReadLine()));
        //    switch (bilietoTipas)
        //    {
        //        case 1:
        //            int parduotiBilietai10 = AmountOfTickets(bilietoTipas, 10);
        //            break;
        //        case 2:
        //            int parduotiBilietai20 = AmountOfTickets(bilietoTipas, 20);
        //            break;
        //        case 3:
        //            int parduotiBilietai30 = AmountOfTickets(bilietoTipas, 30);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public static int AmountOfTickets(int ticketType, int price)
        //{
        //    Console.WriteLine($"How many type {ticketType} tickets would you like to create:");
        //    int ticketAmount = Convert.ToInt32(Console.ReadLine());
        //    return ticketAmount * price;
        //}
        public static int totalCreated10 = 0;
        public static int totalSold10 = 0;

        public static int totalCreated20 = 0;
        public static int totalSold20 = 0;

        public static int totalCreated30 = 0;
        public static int totalSold30 = 0;

        static void Main(string[] args)
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Pirkti bilietus");
                Console.WriteLine("2. Kurti bilietus");
                Console.WriteLine("3. Kiek sukurta ir kiek parduota bilietu");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        BuyTickets();
                        break;
                    case 2:
                        CreateTickets();
                        break ;
                    case 3:
                        PrintSales();   
                        break ; 
                }
            }
        }

        

        private static void CreateTickets()
        {
            Console.WriteLine("Pasirinkite bilieto tipa: [1] po 10 eur, [2] po 20 eur, [3] po 30 eur");
            int ticketType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek tokiu bilietu noresite?");
            int ticketsAmount = Convert.ToInt32(Console.ReadLine());
            switch (ticketType)
            {
                case 1:
                    totalCreated10 += ticketsAmount;
                    break;
                case 2:
                    totalCreated20 += ticketsAmount;
                    break;
                case 3:
                    totalCreated30 += ticketsAmount;
                    break ;

            }
        }

        private static void BuyTickets()
        {
            Console.WriteLine("Pasirinkite bilieto tipa: [1] po 10 eur, [2] po 20 eur, [3] po 30 eur");
            int ticketType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek tokiu bilietu noresite?");
            int ticketsAmount = Convert.ToInt32(Console.ReadLine());

            switch (ticketType) 
            {
                case 1:
                    totalCreated10 -= ticketsAmount;
                    totalSold10 += ticketsAmount;
                    break;
                case 2:
                    totalCreated20 -= ticketsAmount;
                    totalSold20 += ticketsAmount;
                    break ;
                case 3:
                    totalCreated30 -= ticketsAmount;
                    totalSold30 += ticketsAmount;
                    break;
            }
        }
        private static void PrintSales()
        {
            Console.WriteLine($"Created 10e: {totalCreated10} and sold: {totalSold10}");
            Console.WriteLine($"Created 20e: {totalCreated20} and sold: {totalSold20}");
            Console.WriteLine($"Created 30e: {totalCreated30} and sold: {totalSold30}");
        }
    }
}
