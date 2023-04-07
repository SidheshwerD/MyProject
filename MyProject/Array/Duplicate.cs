using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// How to find duplicate Element in array

namespace MyProject.Array
{
    internal class Duplicate
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 1, 2, 9, 4,2,3,3};
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]==a[j])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }
    }

}
