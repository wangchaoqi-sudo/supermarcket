using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarcket
{
    class ProductFather
    {
        public string id { get; set; }
        public double price { get; set; }
        public string name { get; set; }

        public ProductFather(string id, double price, string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
    }
}
