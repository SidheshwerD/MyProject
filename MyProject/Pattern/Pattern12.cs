using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class Pattern12
    {
        static void Main(string[] args)
        {
            int row;
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<='D';j++)
                {
                  if(i == 'A' || i == 'D' || j == 'A' || j == 'D')
                  {
                        Console.Write(j);
                  }
                  else
                  {
                        Console.Write(" ");
                  }
                  
                }
                Console.WriteLine();
            }
        }
    }
}
