using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoriakezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (!Console.KeyAvailable)
            {
                //var streem = new MemoryStream(100000);
                //var bimap = new Bitmap(1280,1024);
                using (var bimap = new Bitmap(1280, 1024)) { }

            }*/
            using (var t1 = new TisztaLevego())
            {
            }

            try
            {

            }
            finally
            {

            }
        }
    }
    class TisztaLevego : IDisposable
    {
        ~TisztaLevego()
        {
            Dispose(false);        
        }

        

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            throw new NotImplementedException();
        }
    }
}
