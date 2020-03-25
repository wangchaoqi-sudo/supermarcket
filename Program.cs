using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarcket
{
    class Program
    {
        static void Main(string[] args)
        {
            supermarket sm = new supermarket();
            sm.ShowPros();
            sm.AskBuying();
            Console.ReadLine();
        }
    }
}
