using System;

namespace Exchange_Dickson
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double amount;
            double initial;
            string again = "y";
            ExchangeMonitor finale = new ExchangeMonitor();
            while (again != "n")
            {
                Console.WriteLine("Select Exchange choice (i.e. usd to gbp; Currencies: usd, gbp, can, eur): ");
                choice = Console.ReadLine();
                Console.WriteLine("Enter initial amount of first currency listed: ");
                amount = Convert.ToDouble(Console.ReadLine());
                initial = amount;
                if (choice == "usd to gbp")
                {
                    amount = Exchanger.usdtogbp(amount);
                }
                else if (choice == "usd to can")
                {
                    amount = Exchanger.usdtocan(amount);
                }
                else if (choice == "usd to eur")
                {
                    amount = Exchanger.usdtoeur(amount);
                }
                else if (choice == "gbp to usd")
                {
                    amount = Exchanger.gbptousd(amount);
                }
                else if (choice == "gbp to can")
                {
                    amount = Exchanger.gbptocan(amount);
                }
                else if (choice == "gbp to eur")
                {
                    amount = Exchanger.gbptoeur(amount);
                }
                else if (choice == "can to usd")
                {
                    amount = Exchanger.cantousd(amount);
                }
                else if (choice == "can to gbp")
                {
                    amount = Exchanger.cantogbp(amount);
                }
                else if (choice == "can to eur")
                {
                    amount = Exchanger.cantoeur(amount);
                }
                else if (choice == "eur to usd")
                {
                    amount = Exchanger.eurtousd(amount);
                }
                else if (choice == "eur to gbp")
                {
                    amount = Exchanger.eurtogbp(amount);
                }
                else if (choice == "eur to can")
                {
                    amount = Exchanger.eurtocan(amount);
                }
                Console.WriteLine("Exchanged: " + amount);
                Console.WriteLine("Would you like to make another exchange? (y/n)");
                again = Console.ReadLine();
                double final = Math.Round(finale.totalUp(choice, initial), 2);
                int loops = finale.countLoops();
                if (again == "n")
                {
                    Console.WriteLine("Total amount exchanged (in usd): " + final);
                    Console.WriteLine("Number of exchanges: " + loops);
                }
            }
        }
    }
}
