using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                for(int j=7;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    if(i%2!=0)
                    {
                        Console.Write(k+" ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
