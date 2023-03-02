/*using MyProject.OOPDemo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP to check given number is trimorphic or not

namespace MyProject.Loop
{
    internal class Trimorphicnum
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            int i = n + 3;
            int Product = 1;
           

            while(n<i)
            {
                Product=Product*n;
                i--;

            }
            Console.WriteLine(Product);
            int j = Product + 1;

            while(Product < j )
            {
                int digit = Product % 10;
                i--;
            }
            if (digit == n)
            {
                Console.WriteLine(" Number is Trimorphic ");
            } 
            else
            {
                Console.WriteLine(" Number is not Trimorphic ");
            }
        }
    }
}*/
