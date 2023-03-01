using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern14
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=1;i<=n;i++)
            {
                for(int j=n;j>=1;j--)
                {
                    if (i >= j)
                    {
                        Console.Write(" *");
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
