using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the row num : ");
            int row = int.Parse(Console.ReadLine());

            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=row;j++)
                {
                    if(j == 1 || j == row || j == i )
                    {
                        Console.Write("*");
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
