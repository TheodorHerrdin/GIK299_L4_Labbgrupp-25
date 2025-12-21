using System.Security.Cryptography.X509Certificates;

namespace Evil_Eavesdrop_Enterprises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bool kontrollerarar om huvudloopen ska fortsätta köras
            bool runProgram = true;

            //Huvudloop för programmet
            while (runProgram)
            {
                Console.WriteLine("Välkommen till Evil Eavesdrop Enterprises");
                Console.WriteLine();
                Console.WriteLine("Nummer 1: Lägg till en ny person");
                Console.WriteLine("Nummer 2: Visa lista på alla personer");
                Console.WriteLine("Nummer 3: För att avsluta");
                Console.Write("Välj en siffra: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                //Switch-sats för att hantera användarens menyval
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
                        runProgram = false; //Bryter huvudloopen och avslutar programmet
                        break;
                    default:
                        Console.WriteLine("Bror? Det står väl nummer 1, 2 eller 3.. Prova igen");
                        break;
                }
            }
        }
    }
}
