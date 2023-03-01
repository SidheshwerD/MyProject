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
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i%2!=0)
                    {
                        Console.Write(i);
                    }
                    
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine(  );
            }
        }
    }
}
