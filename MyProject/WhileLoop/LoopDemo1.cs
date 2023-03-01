using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WhileLoop
{
    internal class LoopDemo1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while ( i <= 10)
            {
                sum = sum + i;
            }
            i++;
            Console.WriteLine(sum);
        }
    }
}

    
