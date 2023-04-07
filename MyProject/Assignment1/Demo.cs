using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            String binaryString = Console.ReadLine();

            int decimalValue = Convert.ToInt32(binaryString, 2);

            Console.WriteLine(decimalValue);
        }
    }
}
