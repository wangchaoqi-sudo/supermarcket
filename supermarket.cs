using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarcket
{
    class supermarket
    {
        CangKu ck = new CangKu();
        public supermarket()
        {
            ck.GetPros("Acer", 1000);
            ck.GetPros("SamSung", 1000);
            ck.GetPros("JiangYou", 1000);
            ck.GetPros("Banana", 1000);
        }


    }
}
