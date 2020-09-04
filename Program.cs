using System;
using phone.Classes;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Doo do doo doooo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringg ring ringgg");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("");
        }
    }
}
