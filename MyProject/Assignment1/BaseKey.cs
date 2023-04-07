using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("its base class");
        }
        public void show()
        {
            Console.WriteLine("its base method");
        }

    }

    class Base1:Base
    {
        public Base1():base()
        {
            Console.WriteLine("its base1 class");

        }
        public void show()
        {
            base.show();
            Console.WriteLine("its base1 method");
        }
    }
    internal class BaseKey
    {
        static void Main(string[] args)
        {
            Base1 b = new Base1();
            b.show();
        }
    }
}
