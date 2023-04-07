using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritance
{
    class Shape
    {
        public float area = 0;
    }

    class Circle : Shape
    {
        public void Show()
        {
            Console.WriteLine("Circle area : " + area);
        }
    }

    class Rectangle:Shape
    {

        public void Display()
        {
            Console.WriteLine("Rectangle area : " + area);
        }
    }
        


    internal class HirachicalDemo
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Show();

            Rectangle r = new Rectangle();
            r.Display();
        }
    }
}
