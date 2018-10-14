using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamString
{
    class Program
    {
        static void Main(string[] args)
        { 
            var fileName = "teszt.txt";
            File.WriteAllText(fileName,
                string.Format("file tartalom. \n vagy paaméterek {0} is irhatóak, {0} további pec karakterek {1}, {2}, {3}, {4}",
                Environment.NewLine,
                (char)113, //ASCII karakter
                Convert.ToChar(113), //ASCII karakter
                '\u0027',
                //byte tombot karakterkodokkal stringgé konvertálva
                new string(Encoding.ASCII.GetChars(new byte[] {35,36 }))
                ),
                Encoding.UTF8
                );
            using (var fs = new FileStream(fileName, FileMode.Open))
          
 
 {
                using (var sr = new StreamReader(fs, Encoding.UTF8)) 
                {
                    while (!sr.EndOfStream)
                    {
                        var text = sr.ReadLine();
                        Console.WriteLine(text);
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
