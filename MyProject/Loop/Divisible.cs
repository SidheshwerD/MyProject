using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP to print all numbers between 1 to 100 accept the number which is divisible by 5 or 10

namespace MyProject.Loop  
{
    internal class Divisible
    {
        static void Main(string[] args)
        {
            for (int i= 1;i<= 100;i++)
            {
              if(i%5==0 || i%10==0)
              {
                    Console.WriteLine(i);
              }
            }
        }
    }
}
