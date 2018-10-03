using System;

namespace receptek
{
    class Program
    {
        static void Main(string[] args)
        {
            var ma = DateTime.Today;
            var naneve = ma.DayOfWeek;
            if (naneve == DayOfWeek.Friday)
            {
                Console.WriteLine("szerva van");
            }
            else
            {
                Console.WriteLine(ma);
                Console.WriteLine("hus");
                Console.WriteLine("hagyma");
                Console.WriteLine("paprika");
            }
            
            Console.ReadLine();
        }
        
    }
}
