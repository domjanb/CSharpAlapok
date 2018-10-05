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
                Console.WriteLine(DateTime.Today.GetHashCode());

            }
            else
            {
                Console.WriteLine(DateTime.Today.GetHashCode());
                perkeltKiiratas();
                irdKiAPerkeltet();
            }
        }

        private static void irdKiAPerkeltet()
        {
            throw new NotImplementedException();
        }

        private static void perkeltKiiratas()
        {
            Console.WriteLine("hus");
            Console.WriteLine("hagyma");
            Console.WriteLine("paprika");
        }
    }
}
