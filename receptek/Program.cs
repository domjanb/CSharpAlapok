using System;

namespace receptek
{
    class Program
    {
        static void Main(string[] args)
        {
            var ma = DateTime.Today;
            var naneve = ma.DayOfWeek;
            napiRecept(naneve);

            Console.ReadLine();
        }

        private static void napiRecept(DayOfWeek naneve)
        {
            if (naneve == DayOfWeek.Friday)
            {
                Console.WriteLine("szerva van");
            }
            else
            {
                perkeltKiiratas();
            }
        }

        private static void perkeltKiiratas()
        {
            Console.WriteLine("hus");
            Console.WriteLine("hagyma");
            Console.WriteLine("paprika");
        }
    }
}
