using _16超市收银系统;
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

       public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要什么?");
            Console.WriteLine("我们有 Acer、SamSung、Jiangyou、Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货物
            ProductFather[] pros = ck.QuPros(strType, count);
            //下面该计算价钱了
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元", realMoney);
            Console.WriteLine("请选择您的打折方式 1--不打折 2--打九折  3--打85 折  4--买300送50  5--买500送100");
            string input = Console.ReadLine();
            //通过简单工厂的设计模式根据用户的舒服获得一个打折对象
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元", totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称:" + item.name + "," + "\t" + "货物单价:" + item.price + "," + "\t" + "货物编号：" + item.id);
            }
        }

        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            //realMoney = pros[0].Price * pros.Length;

            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].price;

                // realMoney = pros[i] * pros.Length;
            }
            return realMoney;
        }

        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }
        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
