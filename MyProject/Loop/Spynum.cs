using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP to check given number is SPY number or not

namespace MyProject.Loop
{
    internal class Spynum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            int sum = 0;

            while(n>0)
            {
                int digit = n % 10;
                sum = sum + digit;
                product = product * (digit);
                    n = n / 10;

            }
            if(sum == product)
            {
                Console.WriteLine(" Number is SPY ");
            }
            else
            {
                Console.WriteLine(" Number is not SPY ");
            }
        }
    }
}
