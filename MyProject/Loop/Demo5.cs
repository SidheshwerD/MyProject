using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// write a code to check given number is odd or even by using switchcase

namespace MyProject.Loop
{
    internal class Demo5
    {
        static void Main(string[] args)
        {
            // int num;
            Console.Write(" Enter any number :  ");
            int num = int.Parse(Console.ReadLine());

                 switch (num % 2 == 0)
                 {
                     case true: Console.WriteLine(" Number is Even ");
                     break;
                     default:
                     case false: Console.WriteLine(" Number is Odd ");
                     break;
                 }
        }

    }
}