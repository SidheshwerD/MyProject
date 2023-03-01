using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern13
    {
        static void Main(string[] args)
        {
           // int n = 5;
           // Console.Write("Enter the Number :");
            //int row = int.Parse(Console.ReadLine());
            {
                for(int i=5;i>=1;i--)
                {
                    for(int j=1;j<=i;j++)
                    {
                        if(i>=j)
                        {
                            Console.Write("*");

                        }
                        else
                        {
                            Console.Write("");
                        }
                        
                    }
                    Console.WriteLine();
                    
                }
            }
        }
    }
}
