using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the year : ");
            year = Convert.ToInt32 (Console.ReadLine());
            if(year%400==0)
            {
                Console.Write(year + " is a Leap Year ");
            }
            else if(year%100==0)
            {
                Console.Write(year + " is  not a Leap Year ");
            }
            else if(year%4==0)
            {
                Console.Write(year + " is a Leap Year ");
            }
            else
            {
                Console.Write(year + " is not a Leap Year ");
            }
        }
    }
}
