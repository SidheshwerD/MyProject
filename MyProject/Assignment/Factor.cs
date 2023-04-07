using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.Write(" Enetr the number : ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
