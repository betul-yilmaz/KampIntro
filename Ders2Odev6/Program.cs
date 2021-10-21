using System;

namespace Ders2Odev6
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public bool stock { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Computer";
            product1.price = 2500;
            product1.stock = true;

            Product product2 = new Product();
            product2.name = "Phone";
            product2.price = 2000;
            product2.stock = true;

            Product product3 = new Product();
            product3.name = "Television";
            product3.price = 2000;
            product3.stock = true;

            Product product4 = new Product();
            product4.name = "Laptop";
            product4.price = 3000;
            product4.stock = false;

            Product[] products = new Product[] { product1, product2, product3, product4 };
            Console.WriteLine("use For:");
            //for ile
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name + ":" + products[i].price +"| stock: "+ products[i].stock);
            }
            Console.WriteLine("use Foreach:");
            //foreach ile
            foreach (var product in products)
            {
                Console.WriteLine(product.name + ":" + product.price + "| stock: " + product.stock);
            }
            Console.WriteLine("use While:");
            int k = 0;
            while (k< products.Length)
                {
                Console.WriteLine(products[k].name + ":" + products[k].price + "| stock: " + products[k].stock);
                k++;
            }
        }
    }
}
