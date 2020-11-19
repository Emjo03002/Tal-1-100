using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int slumptal = slump.Next(0,101);
            int gissningar = 0;
            Console.WriteLine("gissa ett tal mellan 1-100");

            int gissning = 0;
            

            while (gissning != slumptal)
            {
                gissning = int.Parse(Console.ReadLine());
                gissningar++;
                if (gissning < slumptal)
                {
                    Console.WriteLine("Din gissning var för låg, försök igen");
                }
                else if(gissning>slumptal)
                {

                    Console.WriteLine("Din gissning var för hög, försök igen");
                }

            }

            Console.WriteLine("Du hade rätt!");
            Console.WriteLine("Du gissade " + gissningar + " gånger");
        } 
    }
}
