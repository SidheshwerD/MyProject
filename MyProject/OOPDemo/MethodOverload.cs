using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class MethodOverLoad
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate");
        }
        public void Calculate(int x, float y)
        {
            Console.WriteLine("sub= " + (x - y));
        }
        public void Calculate(int a,int y)
        {
            Console.WriteLine("Addition= " + (a + y));
        }
        public int Calculate(float x, int y)
        {
            return 0;
        }
        public void Calculate(int x, int y, int z)
        {

        }

        static void Main(string[] args)
        {
            MethodOverLoad m = new MethodOverLoad();
            m.Calculate(2, 3);
            m.Calculate(1, 2.3f);
            m.Calculate();
        }
    }
}
