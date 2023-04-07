using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment
{
    internal class Krishnmurti
    {


        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while(n>0)
            {
                int digit = n % 10;
                int Fact = 1;

                for(int i=1;i<=digit;i++)
                {
                    Fact = Fact * i;

                }
                sum =  sum + Fact;
                n = n / 10;
            }
              if(temp == sum)
              {
                Console.WriteLine(" num is Krishnmurti ");
              }
              else
              {
                Console.WriteLine(" num is not Krishnmurti ");
              }
        }
    }
}
