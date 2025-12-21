using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_Eavesdrop_Enterprises
{
    //Énum med fasta alternativ för kön för att undvika felstavningar
    public enum Gender { Kvinna, Man, Övrigt }

    //Struct för att hantera hår-egenskaper
    public struct Hair
    {
        public string Color;
        public string Length;
    }

    //Klass för att hantera personen
    public class Person
    {
        //Egenskaper som beskriver en person
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public string EyeColor { get; set; }
        public DateTime Birthday { get; set; }

        //Statisk lista för att lagra alla personer
        public static List<Person> PersonList = new List<Person>();
        
        //Konstruktor för att initiera alla egenskaper vid skapandet av nya objekt
        public Person(Gender gender, Hair hair, string eyeColor, DateTime birthday)
        {
            Gender = gender;
            Hair = hair;
            EyeColor = eyeColor;
            Birthday = birthday;
        }

        //Metod för att lägga till en ny person via användarinmatning
        public static void AddPerson()
        {
            Console.Write("Ögonfärg: ");
            String eyeColor = Console.ReadLine();
            Console.Write("Hårfärg: ");
            String hairColor = Console.ReadLine();
            Console.Write("Hårlängd: ");
            String hairLength = Console.ReadLine();

            //Skapar en instans av hair structen med angivna värden
            Hair hair = new Hair { Color = hairColor, Length = hairLength };

            //Variabler för att hantera valet av kön.
            Gender gender;
            int genderChoice = 0;
            bool isGenderValid = false;

            //Loop som tvingar användare att välja ett giltigt könsalternativ
            while (!isGenderValid)
            {
                Console.WriteLine("Välj Kön:");
                Console.WriteLine("1: Kvinna");
                Console.WriteLine("2: Man");
                Console.WriteLine("3: Övrigt");
                Console.Write("Val: ");

                string input = Console.ReadLine();


                if (int.TryParse(input, out genderChoice) && genderChoice >= 1 && genderChoice <= 3)
                {
                    isGenderValid = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ogiltig inmatning av kön, vänligen välj en siffra mellan 1-3.");
                    Console.WriteLine();
                }
            }

            //Omvandlar användarens val till motsvarande enum-värde
            if (genderChoice == 1)
            {
                gender = Gender.Kvinna;
            }
            else if (genderChoice == 2)
            {
                gender = Gender.Man;
            }
            else
            {
                gender = Gender.Övrigt;
            }

            //Vi skpapar variabler för att lagra födelsedatumet innan vi sätter ihop det till ett DateTime-objekt
            DateTime birthday = DateTime.MinValue;
            int year = 0, month = 0, day = 0;

            //Loop för att säkerställa giltigt årtal
            while (true)
            {
                Console.Write("Ange födelseår (YYYY): ");
                if (int.TryParse(Console.ReadLine(), out year) && year >= 1900 && year <= DateTime.Now.Year)
                    break;
                Console.WriteLine("Ogiltigt år, försök igen.");
            }

            //Loop för att säkerställa giltig månad
            while (true) 
            {
                Console.Write("Ange födelsemånad (MM): ");
                if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
                    break;
                Console.WriteLine("Ogiltig månad, försök igen.");
            }

            //Loop för att säkerställa giltig dag
            while (true) 
            {
                Console.Write("Ange födelsedag (DD): ");
                if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
                {
                    try
                    {
                        birthday = new DateTime(year, month, day);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine($"Ogiltigt datum {year}-{month}-{day} finns inte, vänligen kontrollera uppgifterna och fyll i på nytt.");
                    }
                }
                else 
                {
                    Console.WriteLine("Ogiltig dag, försök igen.");
                }
            }

            
            //Skapar en ny person med angivna värden och lägger till i listan
            Person newPerson = new Person(gender, hair, eyeColor, birthday);
            PersonList.Add(newPerson);

            Console.WriteLine();
            Console.WriteLine("Personen har lagts till i listan ");
        }

        //Går igenom listan och skriver ut varje persons information med hjälp av ToString-metoden
        public static void ListPerson()
        {
            if (PersonList.Count == 0)
            {
                Console.WriteLine("Inga personer tillagda ännu.");
                return;
            }
            foreach (var p in PersonList)
            {
                Console.WriteLine(p.ToString());
            }
        }

        //Bestämmer hur en persons information ska presenteras som en sträng
        public override string ToString()
        {
            return $"Född: {Birthday:yyyy-MM-dd}" +
                   $"\nKön: {Gender}" +
                   $"\nÖgon: {EyeColor}" +
                   $"\nHår: {Hair.Color} & {Hair.Length}";
        }
    }
}
