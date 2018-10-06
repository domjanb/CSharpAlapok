using System;
using System.Collections.Generic;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teglalap = new Teglalap(magassag: 3, szelesseg: 2);
            var haromszog = new Haromszog(alap: 10, magassag: 10);
            var kor = new Kor(sugar: 3);

            var lista = new List<ISikidom>();
            lista.Add(teglalap);
            lista.Add(haromszog);
            lista.Add(kor);
            var sum = 0;
            foreach (var sikidom in lista)
            {
                sum = sum + sikidom.Terulet();
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine(GC.GetGeneration(kor));

            Console.ReadLine();
        }
    }
    //nem tudom milyne sikidomrol van szo, ezert nem tudok teruletet szamolni
    /*class Sikidom
    {
        public int Terulet()
        {
            return 0;
        }
    }
    */

        //minden osztaly ami a az interfacet megvalositja, annak meg kell valositania a terulet fuggvenyt aminek integer visszateresi erteke kell hogy legyen
    interface ISikidom
    {
        int Terulet();
    }

    class Haromszog : ISikidom
    {
        public Haromszog(int alap, int magassag)
        {
            Alap = alap;
            Magassag = magassag;
        }

        public int Magassag { get; private set; }
        public int Alap { get; private set; }

        public int Terulet()
        {
            return Alap * Magassag / 2;
        }
    }

    class Teglalap : ISikidom
    {
        public Teglalap(int magassag, int szelesseg)
        {
            Magassag = magassag;
            Szelesseg = szelesseg;
        }
        public int Magassag { get; private set; }
        public int Szelesseg { get; private set; }

        public int Terulet()
        {
            return Magassag * Szelesseg;
        }
    }
    class Kor : ISikidom
    {
        public Kor(int sugar)
        {
            Sugar = sugar;
        }

        public int Sugar { get; private set; }

        public int Terulet()
        {
            return (int)(Sugar * Sugar * Math.PI);
        }
    }
}
