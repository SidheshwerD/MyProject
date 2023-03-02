using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Predict the output of the following code

namespace MyProject.Loop
{
    internal class Demo8
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k= " + k + " i= " + i);
        }
    }
}
