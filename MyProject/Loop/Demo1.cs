using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write code to display odd number between 35 to 50.

namespace MyProject.Loop
{
    internal class Demo1
    {
        static void Main(string[] args)
        {
            for(int i=35;i<=50;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }

            }
              
        }
    }
}
