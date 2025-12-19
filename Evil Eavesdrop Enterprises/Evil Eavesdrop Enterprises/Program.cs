using System.Security.Cryptography.X509Certificates;

namespace Evil_Eavesdrop_Enterprises
{
    //Enum för att representera kön
    public enum Gender 
    {
        Kvinna,
        Man,
        Övrigt
    }

    //Struct för att representera hår
    public struct Hair 
    {
        public string Color;
        public string Length;
    }

    //Klass för att representera en person
    public class Person 
    {
        public Gender Gender;
        public Hair Hair;
        public string EyeColor;
        public DateTime Birthday;

        public override string ToString()
        {
            return "Född: " + Birthday.ToShortDateString() +
                "\nkön: " + Gender +
                "\nÖgon: " + EyeColor +
                "\nHår: " + Hair.Color + " & " + Hair.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en hårdkodad person
            Person p1 = new Person();

            p1.Gender = Gender.Man;
            p1.EyeColor = "lila";
            p1.Birthday = new DateTime(1995, 1, 17);

            p1.Hair = new Hair();
            p1.Hair.Color = "Grönt";
            p1.Hair.Length = "långt";

            //Skriv ut personen
            Console.WriteLine(p1);

            //Så konsolen inte stängs direkt
            Console.ReadLine();
        }
    }
}
