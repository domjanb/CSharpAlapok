using System;

namespace construktorok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Futtatasok();
            


            Console.ReadLine();
        }

        private static void Futtatasok()
        {
            var alap = new Alap("geza", "kresz g u 2");
            Console.WriteLine();

            var leszarmaztatott = new Leszarmaztatott();
            Console.WriteLine();

            var tovabbszarmaztatott = new TovabbSzarmaztatott();
            Console.WriteLine();
        }

        class Alap
        {
            string Nev;
            string Cim;
            string Semmi;

            public Alap()
            {
                Console.WriteLine("alap ctor0 fut");
            }
            public Alap(string nev) : this()
            {
                Console.WriteLine("alap ctor2 fut {0}",nev);
                Nev = nev;
            }
            public Alap(string nev, string cim) : this(nev)  //a this miatt orokli az elozo konstruktor tevékenységét konkrétan a nev -et tole
            {
                Console.WriteLine("alap ctor3 fut {0} , {1}", nev,cim);
                
                Cim = cim;
            }
            //finelaizer , lefut ha az osztaly befejezte at életét
            ~Alap()
            {
                Console.WriteLine("alap befejezte");
            }
        }

        class Leszarmaztatott :Alap
        {
            public Leszarmaztatott()
            {
                Console.WriteLine("leszarmaztatott ctor fut");
            }
            ~Leszarmaztatott()
            {
                Console.WriteLine("leszarmaztatott befejezte");
            }
        }
        class TovabbSzarmaztatott : Leszarmaztatott
        {
            public TovabbSzarmaztatott()
            {
                Console.WriteLine("továbbszármaztatott ctor fut");
            }
            ~TovabbSzarmaztatott()
            {
                Console.WriteLine("tovabbszarmaztatott befejezte");
            }
        }
    }
    


}
