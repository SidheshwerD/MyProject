using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class Product
    {
        string pname;
        int price;
        int qty;

        public void ProductDetails()
        {
            pname = "samsung";
            price = 1500;
            qty = 2;
        }
        public void Display()
        {
            Console.WriteLine(pname + " \n " + price + " \n "+ qty);
        }

        static void Main(string[] args)
        {
            Product p = new Product();
            p.ProductDetails();
            p.Display();
        }
    }
}
