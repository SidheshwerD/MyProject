using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Array
{
    internal class MergeAlter
    {
        public static void Main(string[] args)
        {

            int[] a = new int[7] { 1, 3, 5, 7, 9, 11, 13 };
            int[] b = new int[5] { 2, 6, 8, 10, 12 };
            int[] c = new int[12];
            int i, j, k;


            Console.Write(" Elements of the array A : ");

            for (i = 0; i < 7; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.Write("\n Elements of the array B : ");

            for (i = 0; i < 5; i++)
            {
                Console.Write(b[i] + " ");

            }

            Console.Write("\n....................................................");
            Console.WriteLine(" ");
            Console.Write("\n Merge array in c : ");

            for (i = 0; i < 7; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < 5; j++)
            {
                c[i] = b[j];
                i++;
            }
            for (i = 0; i < 12; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
        }


    }
}

