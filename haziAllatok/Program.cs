using System;

namespace haziAllatok
{
    class Program
    {
        static void Main(string[] args)
        {
            var kutya = new Kutya();
            Console.WriteLine("kutya-kutya");
            kutya.Koszon();
            kutya.Enekel();
            kutya.Beszel();
            Console.WriteLine("\n");

            Kutya kutya2 = new Kutya();
            Console.WriteLine("kutya-kutya");
            kutya2.Koszon();
            kutya2.Enekel();
            kutya2.Beszel();
            Console.WriteLine("\n");



            var haziAllat = new HaziAllat();
            Console.WriteLine("haziallat-haziallat");
            haziAllat.Koszon();
            haziAllat.Enekel();
            haziAllat.Beszel();
            Console.WriteLine("\n");

            HaziAllat haziAllat1 = new Kutya();
            Console.WriteLine("haziallat-kuzya");
            haziAllat1.Koszon();
            haziAllat1.Enekel();
            haziAllat1.Beszel();
            Console.WriteLine("\n");

            Console.WriteLine("haziallat(kutya) cast kuzya");
            ((Kutya)haziAllat1).Koszon();
            ((Kutya)haziAllat1).Enekel();
            ((Kutya)haziAllat1).Beszel();
            Console.WriteLine("\n");



            var haziAllat2 = new Kutya();
            //kulya tipusnakveszem a háziállat felüleltét
            Console.WriteLine("kutya cast haziallat");
            ((HaziAllat)haziAllat2).Koszon();
            ((HaziAllat)haziAllat2).Enekel();
            ((HaziAllat)haziAllat2).Beszel();
            Console.WriteLine("\n");

            //nem lehet
            /*var haziAllat3 = new HaziAllat();
            Console.WriteLine("haziallat cast kutya");
            ((Kutya)haziAllat3).Koszon();
            ((Kutya)haziAllat3).Enekel();
            ((Kutya)haziAllat3).Beszel();
            Console.WriteLine("\n");*/


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

        public new void  Enekel()
        {
            Console.WriteLine("kutya enekel ");
        }
        public override void Beszel()
        {
            Console.WriteLine("kuzya beszel ");
            base.Beszel();
        }

    }
}
