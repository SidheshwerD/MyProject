using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class BinarytoDec
    {
        static void Main(string[] args)
        {
            int m, n, p = 1;
            int dec = 0, i = 1, j, d;
            Console.Write(" Enter binary number : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            for(j=n;j>0;j=j/10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                dec = dec + (d * p);
                i++;
            }
            Console.Write("\n the binary number : {0} \n the equivalent decimal  number : {1} \n\n",n ,dec);
            
        }
    }
}
