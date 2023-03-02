using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* WAP to print mumber from 1 to 100 if number is even then print as it is and the number is odd then print
 negtive number with the square*/

namespace MyProject.Loop
{
    internal class Demo9
    {
        static void Main(string[] args)
        {
            int ons = 1;
            Console.Write("Even number : ");
            
            for(int i=1; i<=100;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i%2! == 0)
                {
                    ons = i * i;
                    Console.WriteLine(ons);
                }
            }
        }
    }
}
