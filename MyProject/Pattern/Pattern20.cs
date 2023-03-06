using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern20
    {
        static void Main(string[] args)
        {
           
            
            for(int i=1;i<=4;i++)
            {
               char ch = 'A';
               if (i%2!=0)
               {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
               }
               else
               {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
               }

                Console.WriteLine();
               
            }
            
        }
    }
}
