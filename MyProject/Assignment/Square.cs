using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// print number from 1 to 100 if number is even then print as ut is and number is odd then its square

namespace MyProject.Assignment
{
    internal class Square
    {
        static void Main(string[] args)
        {
            int ons = 1;
            Console.WriteLine("Enter Number : ");
            for(int i=1;i<=100;i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for(int i=1;i<=100;i++)
            {
                if(i%2!=0)
                {
                    ons = i * i;
                    Console.WriteLine(ons);
                }
            }
        }
    }
}
