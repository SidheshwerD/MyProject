using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment
{
    class Nib
    {
        int price;
        public Nib(int price)
        {
            this.price = price;
        }
        public void NibDetail()
        {
            Console.WriteLine("Nib Detail : " + price);

        }
    }
    class Pen
    {

        string color;
        string name;
        string type;
        Nib nib;

        public Pen(string color, string name, string type, Nib nib)
        {
            this.color = color;
            this.name = name;
            this.type = type;
            this.nib = nib;
        }

        public void DisplayPen()
        {
            Console.WriteLine("pen Details = " + color + " " + name + " " + type);
            nib.NibDetail();
        }
    }
    internal class Bag
    {

        string bagname;
        string bagcolor;
        int price;
        Pen pen;
        
        Bag(string bagname,string bagcolor,int price,Pen pen)
        {
            this.bagname = bagname;
            this.bagcolor = bagcolor;
            this.price = price;
            this.pen = pen;
        }

        public void showDetail()
        {
            Console.WriteLine("Bag Detail = " + bagname + " Bag color = " + bagcolor + " Bag price " + price);
            pen.DisplayPen();
        }

        static void Main(string[] args)
        {
            Nib n = new Nib(22);
            Pen p = new Pen("Red", "Reynolds", "jel", n);
            Bag b = new Bag("star", "black", 320,p);
            b.showDetail();

        }
    }


}




