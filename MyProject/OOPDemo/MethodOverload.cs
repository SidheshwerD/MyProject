using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class MethodOverload
    {
        public void  Calculate()
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
        public void Main(string[] args)
        {
            MethodOverload m = new MethodOverload();
            m.Calculate(2, 3);
            m.Calculate(1, 2.3f);
            m.Calculate();
        }
    }
}
