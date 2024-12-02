using System;

class GreenvilleRevenue
{
    static void Main(string[] args)
    {

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    CalculateRevenue();
                    break;

                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please enter 1 or 2.");
                    break;
            }
        }
    }

    static void CalculateRevenue()
    {
        Console.Write("Enter the number of contestants last year: ");
        int lastYearContestants = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter the number of contestants this year: ");
        int thisYearContestants = int.Parse(Console.ReadLine().Trim());

        const int ticketPrice = 25; 
        int revenue = thisYearContestants * ticketPrice;

        Console.WriteLine();
        Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
        Console.WriteLine($"Revenue expected this year is ${revenue}");

        if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        }
        else if (thisYearContestants < lastYearContestants)
        {
            Console.WriteLine("It is false that this year's competition is bigger than last year's.");
        }
        else
        {
            Console.WriteLine("The number of contestants is the same as last year.");
        }
        Console.WriteLine("\n************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }
}