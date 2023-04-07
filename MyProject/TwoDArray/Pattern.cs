using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.TwoDArray
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 4, 5, 9, 7 }, { 5, 6, 2, 4 }, { 4, 9, 3, 7 } };
            for(int i = 0;i<a.GetLength(0);i++)
            {
                for(int j = 0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("......................................");

            for(int i = 0;i<a.GetLength(0);i++)
            {
                for(int j = 0;j<a.GetLength(1);j++)
                {
                    if(i==0 || j==0 || i== a.GetLength(0)-1 ||j==a.GetLength(1)-1)
                    {
                        Console.Write(a[i, j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
