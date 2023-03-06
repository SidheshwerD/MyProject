using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritance
{
    class Mobile
    {
       public String color = " Red ";
       public string ram = " 8GB ";
    }

    class Samsung:Mobile
    {
        int price = 23000;

        public void Display()
        {
            Console.WriteLine(color + " " + ram + " " + price);
        }
    }



    internal class SingleDemo2
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            s.Display();
        }
    }
}
