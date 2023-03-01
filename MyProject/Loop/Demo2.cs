using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   // write code to findout sum of 1 to 10 numbers

namespace MyProject.Loop
{
    internal class Demo2
    {
         static void Main(string[] args)
         {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;
            }
              Console.WriteLine(sum);
         }
    }
}
