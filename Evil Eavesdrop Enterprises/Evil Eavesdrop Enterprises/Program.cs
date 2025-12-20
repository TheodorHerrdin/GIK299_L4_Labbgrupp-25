using System.Security.Cryptography.X509Certificates;

namespace Evil_Eavesdrop_Enterprises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bool för att hålla igång programmet
            bool runProgram = true;

            //Huvudloop för programmet
            while (runProgram)
            {
                Console.WriteLine("Välkommen till Evil Eavesdrop Enterprises");
                Console.WriteLine();
                Console.WriteLine("Nummer 1: Lägg till en ny person");
                Console.WriteLine("Nummer 2: Visa lista på alla personer");
                Console.WriteLine("Nummer 3: Välj nummer 1 eller 2 för att gå vidare och 3 för att avsluta");
                Console.WriteLine("Nummer 4: För att avsluta");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Person.AddPerson();
                        Console.WriteLine();
                        break;
                    case "2":
                        Person.ListPerson();
                        Console.WriteLine();
                        break;
                    case "3":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Bror? Det står väl nummer 1 eller 2.. Prova igen");
                        break;
                        Console.WriteLine();
                }
            }
        }
    }
}
