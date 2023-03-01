using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Maxnumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine(num1);
            }
            if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
