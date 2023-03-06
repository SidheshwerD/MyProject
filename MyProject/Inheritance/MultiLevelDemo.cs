using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritance
{
    class Mobiles
    {
       
        public int price = 23000;
    }

    class Oppo:Mobiles
    {

        public String color = " Red ";

    }

    class Nokia:Oppo
    {
         string ram = " 8GB ";

        public void Display()
        {
            Console.WriteLine(price + " " + color + " " + ram);
        }
    }




    internal class MultiLevelDemo
    {
        static void Main(string[] args)
        {
            Nokia n = new Nokia();
            n.Display();
        }

    }
}
