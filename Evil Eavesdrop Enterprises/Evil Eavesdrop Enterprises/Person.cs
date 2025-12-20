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
            Console.Write("Ögonfärg: ");
            String eyeColor = Console.ReadLine();
            Console.Write("Hårfärg: ");
            String hairColor = Console.ReadLine();
            Console.Write("Hårlängd: ");
            String hairLength = Console.ReadLine();
            Hair hair = new Hair { Color = hairColor, Length = hairLength };


            Gender gender;
            int genderChoice = 0;
            bool isGenderValid = false;

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
                    Console.WriteLine("Ogiltig inmatning, vänligen välj en siffra mellan 1-3.");
                    Console.WriteLine();
                }
            }


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


            DateTime birthday = DateTime.MinValue;
            bool isDateTimeValid = false;

            while (!isDateTimeValid)
            {
                try
                {
                    Console.WriteLine("Ange födelseår");
                    Console.Write("År (YYYY): ");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ange födelsemånad");
                    Console.Write("Månad (MM): ");
                    int month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ange födelsdag");
                    Console.Write("Dag (DD): ");
                    int day = int.Parse(Console.ReadLine());

                    birthday = new DateTime(year, month, day);
                    isDateTimeValid = true;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Fel vid inmatning av datum ogiltigt datum angivet, vänligen försök igen.");
                    Console.WriteLine();
                }
            }

            Person newPerson = new Person(gender, hair, eyeColor, birthday);
            PersonList.Add(newPerson);

            Console.WriteLine("Personen har lagts till i listan ");
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
