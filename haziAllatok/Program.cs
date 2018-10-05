using System;

namespace haziAllatok
{
    class Program
    {
        static void Main(string[] args)
        {
            var kutya = new Kutya();
            kutya.Koszon();
            kutya.Enekel();
            kutya.Beszel();
            Console.WriteLine("\n");

            Kutya kutya2 = new Kutya();
            kutya2.Koszon();
            kutya2.Enekel();
            kutya2.Beszel();
            Console.WriteLine("\n");



            var haziAllat = new HaziAllat();
            haziAllat.Koszon();
            haziAllat.Enekel();
            haziAllat.Beszel();
            Console.WriteLine("\n");

            var haziAllat2 = new Kutya();
            haziAllat2.Koszon();
            haziAllat2.Enekel();
            haziAllat2.Beszel();
            Console.WriteLine("\n");


            Console.ReadLine();
        }
    }
    class HaziAllat
    {
        public void Koszon()
        {
            Console.WriteLine("haziallt szevasz helloe ");
        }
        public void Enekel()
        {
            Console.WriteLine("haziallat enekel ");
        }
        public virtual void Beszel()
        {
            Console.WriteLine("haziallat beszel ");
        }
    }
    class Kutya :HaziAllat
    {

        public void Enekel()
        {
            Console.WriteLine("kutya enekel ");
        }
        public override void Beszel()
        {
            Console.WriteLine("kuzya beszel ");
        }

    }
}
