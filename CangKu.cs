using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarcket
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        //List<ProductFather> list = new List<ProductFather>(); //取货物不好取
        //list[0]商品1
        //list[1]商品2
        //list[2]商品3
        //list[3]商品4
        //仓库中创建货架
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }


        public  void GetPros(string strType,int count)
        {
            for(int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "棒之手机"));
                        break;
                    case "JiangYou":
                        list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                        break;
                }
            }
        }

        //取货
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
        //向用户展示货物
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].name + "," + "\t" + "有" + item.Count + "个," + "\t" + "每个" + item[0].price + "元");
            }
        }

        //存储货物 
        //List<Samsung> listSam = new List<Samsung>();
        //List<Acer> listAcer = new List<Acer>();
        //List<JiangYou> listJiangYou = new List<JiangYou>();
        //List<Banana> listBanana = new List<Banana>();
    }
}
