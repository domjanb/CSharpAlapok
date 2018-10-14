using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializalas
{
    class Program
    {
        static void Main(string[] args)
        {
            var adat = new AdatOsztaly() {
                Egesz = int.MaxValue,
                TizedesTort = 12.728m,
                DatumIdo = DateTime.MaxValue,
                Datummin = DateTime.MinValue,
                Szoveg = "ÁrvízTüro"

            };
            var fileNeve = "tesztfile.txt";
            var serializer = new XmlSerializer(typeof(AdatOsztaly));
            using (var fs = new FileStream(fileNeve, FileMode.Create))
            {
                
                serializer.Serialize(fs, adat);
            }
            using (var fs = new FileStream(fileNeve, FileMode.Open))
            {

                var beolvasott= serializer.Deserialize(fs);
                Console.WriteLine(beolvasott);
                Console.ReadLine();
            }
        }

    }
    public class AdatOsztaly
    {
        public int Egesz { get; set; }
        public decimal TizedesTort { get; set; }
        public DateTime DatumIdo { get; set; }
        public DateTime Datummin { get; set; }
        public string Szoveg { get; set; }


    }
}
