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
                ", kön; " + Gender +
                ", Ögon: " + EyeColor +
                ", Hår: " + Hair.Color + ", " + Hair.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
