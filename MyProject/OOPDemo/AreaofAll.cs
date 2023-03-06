using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class AreaofAll
    {
        
        public double Area(double redius)
        {
            return 3.14 * redius * redius;

        }
        public double Area(double length,double width)
        {
            return length * width;
        }
        public double Area(int baseLength, int height)
        {
            return 0.5 * baseLength * height;
        }
        public double Area(int length)
        {
            return length * length;
        }
    }
    public class Calculate
    {
        static void Main(string[] args)
        {
            AreaofAll a = new AreaofAll();

          

            double circleArea = a.Area(4);
            Console.WriteLine(" AreaofAll of circle : " + circleArea);

            double rectangleArea = a.Area(4, 8);
            Console.WriteLine(" AreaofAll of rectangle : " + rectangleArea);

            double triangleArea = a.Area(4, 8);
            Console.WriteLine(" AreaofAll of triangle : " + triangleArea);

            double squareArea = a.Area(4);
            Console.WriteLine(" AreaofAll of square : " + squareArea);
        }
    }
}
