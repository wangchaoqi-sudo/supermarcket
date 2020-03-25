using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarcket
{
    class Banana : ProductFather
    {
        public Banana(string id, double price, string name)
           : base(id, price, name)
        {

        }
    }
}
