using System;



namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string name = Console.ReadLine();

            Console.WriteLine("Kiek valandu miegojote praeita nakti?");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            if (hours >= 8)
            {
                Console.WriteLine($"{name} turetum but gerai pamiegojes, nes miegojai {hours} valandas");
            }
            else
            {
                Console.WriteLine($"{name}, turetu trukti miego, kadangi miegojai {hours} valandas");
            }

            

        }
    }
}
