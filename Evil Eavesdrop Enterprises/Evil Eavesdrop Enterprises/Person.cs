using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_Eavesdrop_Enterprises
{
    //Énum för att hantera kön
    public enum Gender { Kvinna, Man, Övrigt }

    //Struct för att hantera hår
    public struct Hair
    {
        public string Color;
        public string Length;
    }

    //Klass för att hantera personen
    public class Person
    {
        //Egenskaper
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public string EyeColor { get; set; }
        public DateTime Birthday { get; set; }
        public static List<Person> PersonList = new List<Person>();
        //Konstruktor för att initiera alla egenskaper vid skapandet av objektet
        public Person(Gender gender, Hair hair, string eyeColor, DateTime birthday)
        {
            Gender = gender;
            Hair = hair;
            EyeColor = eyeColor;
            Birthday = birthday;
        }
        
        public static void AddPerson()
        {
            try
            {
                Console.Write("Ögonfärg: ");
                String eyeColor = Console.ReadLine();
                Console.Write("Hårfärg: ");
                String hairColor = Console.ReadLine();
                Console.Write("Hårlängd: ");
                String hairLength = Console.ReadLine();
                Hair hair = new Hair
                {
                    Color = hairColor,
                    Length = hairLength
                };
                Console.WriteLine("Välj Kön:");
                Console.WriteLine("1: Kvinna");
                Console.WriteLine("2: Man");
                Console.WriteLine("3: Övrigt");
                Console.Write("Val: ");

                int GenderChoice = int.Parse(Console.ReadLine());
                Gender gender = GenderChoice switch
                {
                    1 => Gender.Kvinna,
                    2 => Gender.Man,
                    3 => Gender.Övrigt,
                    _ => throw new Exception("Ogiltigt val för kön.")
                };

                Console.Write("Födelseår ");
                int Year = int.Parse(Console.ReadLine());

                Console.Write("Födelsemånad ");
                int Month = int.Parse(Console.ReadLine());

                Console.Write("Födelsdag ");
                int Day = int.Parse(Console.ReadLine());

                DateTime Birthday = new DateTime(Year, Month, Day);
                Person newPerson = new Person(gender, hair, eyeColor, Birthday);
                PersonList.Add(newPerson);

                Console.WriteLine("Person tillagd framgångsrikt!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid tillägg av person: ");
            }
        }
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

        public override string ToString()
        {
            return $"Född: {Birthday:yyyy-MM-dd}" +
                   $"\nKön: {Gender}" +
                   $"\nÖgon: {EyeColor}" +
                   $"\nHår: {Hair.Color} & {Hair.Length}";
        }
    }
}
