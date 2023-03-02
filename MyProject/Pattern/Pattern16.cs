using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern16
    {

        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 1; i <= 7; i++)
            {
                for(int k=i;k<7;k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n; j++)
                {
                
                    {
                        Console.Write(i+" ");
                    }
                    
                   


                }
                n=n+2;
                Console.WriteLine(  );
            }
        }
    }
}
