using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritance
{
    class Laptop
    {
        public String memory = "8GB";

    }

    class Dell:Laptop
    {
        int price = 22000;

        public void show()
        {
            Console.WriteLine(memory + " " + price);
        }
    }



    internal class SingleDemo
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            d.show();
        }
    }
}
