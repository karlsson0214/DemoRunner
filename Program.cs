using System;

namespace DemoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Test myTest = new Test();
            myTest.Run();
            //Run();
        }
        static void Run()
        {
            Database db = new Database();

            Console.WriteLine("Välkommen");

            PrintMenu();
            string choice = Console.ReadLine();
            while (choice != "a")
            {
                if (choice == "1")
                {
                    Console.WriteLine("Ange namn på löpare");
                    String nameRunner = Console.ReadLine();

                    Console.WriteLine("Ange distans i meter.");
                    int distanceRunner;
                    distanceRunner = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ange tid i sekunder, decimaltal");
                    double timeRunner;
                    timeRunner = Convert.ToDouble(Console.ReadLine());

                    Runner theRunner = new Runner();
                    theRunner.name = nameRunner;
                    theRunner.distance = distanceRunner;
                    theRunner.time = timeRunner;

                    db.AddRunner(theRunner);
                }
                else if (choice == "2")
                {
                    db.PrintRunners();
                }
                else
                {
                    Console.WriteLine("valet finns inte");
                    PrintMenu();

                }
                PrintMenu();
                choice = Console.ReadLine();
            }

        }


        static void PrintMenu()
        {
            Console.WriteLine("Välj ett alternativ.");
            Console.WriteLine("1 mata in ett resultat");
            Console.WriteLine("2 skriv ut resultat");
            Console.WriteLine("a avsluta");
        }
    }
}
