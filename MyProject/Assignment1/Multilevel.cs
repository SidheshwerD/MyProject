using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    class Vehicle
    {
        public void show()
        {
            Console.WriteLine("show Vehicle ");
        }
    }
    class Riksha:Vehicle
    {
        public void show1()
        {
            show();
            Console.WriteLine("show Riksha");
        }
    }
    class ERiksha:Riksha
    {
        public void show2()
        {
            Console.WriteLine("show ERiksha");
        }

    }
    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Riksha r = new Riksha();
            r.show1();

            ERiksha e = new ERiksha();
            e.show2();
        }
    }
}
