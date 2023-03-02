using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP to print Fibbo seried=s upto 20 terms

namespace MyProject.Loop
{
    internal class FibboSeries
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the series number : ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;

            for(int i=0;i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
        }
    }
}
