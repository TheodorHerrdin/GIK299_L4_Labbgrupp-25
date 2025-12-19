using System.Security.Cryptography.X509Certificates;

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

        //Konstruktor för att initiera alla egenskaper vid skapandet av objektet
        public Person(Gender gender, Hair hair, string eyeColor, DateTime birthday)
        {
            Gender = gender;
            Hair = hair;
            EyeColor = eyeColor;
            Birthday = birthday;
        }

        //ToString metod för att skriva ut personens information
        public override string ToString()
        {
            return $"Född: {Birthday:yyyy-MM-dd}" +
                   $"\nKön: {Gender}" +
                   $"\nÖgon: {EyeColor}" +
                   $"\nHår: {Hair.Color} & {Hair.Length}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //För att skapa håret till konstruktorn
            Hair myHair = new Hair { Color = "Grönt", Length = "långt" };

            //SKAPA PERSON VIA KONSTRUKTORN
            Person p1 = new Person(Gender.Man, myHair, "lila", new DateTime(1995, 1, 17));

            //Skriv ut personen (ToString körs automatiskt)
            Console.WriteLine(p1);

            Console.ReadLine();

            Console.WindowHeight = 40;
        }
    }
}
