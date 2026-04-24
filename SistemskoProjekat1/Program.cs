using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using ExcelDataReader;

namespace SistemskoProjekat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server();
            //da ne bi blokirali unos sa Strart jer on ima blokirjuce funkcije u sebi
            ThreadPool.QueueUserWorkItem(_ => s.Start());
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str == "stop")
                {
                    s.Stop();
                    break;
                }
            }
        }
    }
}
