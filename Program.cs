using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyProduct product1 = new MyProduct();
            product1.ProductName = "Kulaklık";
            product1.ProdcutPrice = 300.15;
            product1.ProdcutQuintity = 50;

            MyProduct product2 = new MyProduct();
            product2.ProductName = "Mouse";
            product2.ProdcutPrice = 165.34;
            product2.ProdcutQuintity = 150;

            MyProduct product3 = new MyProduct();
            product3.ProductName = "Klavye";
            product3.ProdcutPrice = 950.130;
            product3.ProdcutQuintity = 30;

            MyProduct[] products = { product1, product2, product3 };

            Console.WriteLine("\n\nForeach Döngüsü\n\n=========================");

            foreach (var product in products)
            {
                Console.WriteLine("---------------------------\nName:" + " " + product.ProductName + "\nPrice:" + " " + product.ProdcutPrice + "\nStock:" + " " + product.ProdcutQuintity);
            }

            Console.WriteLine("\n\nFor Döngüsü\n\n=========================");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("---------------------------\nName:" + " " + products[i].ProductName + "\nPrice:" + " " + products[i].ProdcutPrice + "\nStock:" + " " + products[i].ProdcutQuintity);
            }

            Console.WriteLine("\n\nWhile Döngüsü\n\n=========================");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("---------------------------\nName:" + " " + products[j].ProductName + "\nPrice:" + " " + products[j].ProdcutPrice + "\nStock:" + " " + products[j].ProdcutQuintity);
                j++;
            }

        }
    }
}

class MyProduct
{
    public string ProductName { get; set; }
    public double ProdcutPrice { get; set; }
    public int ProdcutQuintity { get; set; }
}
