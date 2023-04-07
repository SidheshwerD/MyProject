using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.TwoDArray
{
    internal class Pattern1
    {
        public static void ShowPattern(char[,] ch)
        {
            for (int i = 0; i < ch.GetLength(0); i++)
            {
                for (int j = 0; j < ch.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == ch.GetLength(0) - 1 || j == ch.GetLength(1) - 1)
                    {
                        ch[i, j] = '*';
                    }
                    else
                    {
                        ch[i, j] = ' ';
                    }
                }

            }

            for (int i = 0; i < ch.GetLength(0); i++)
            {
                for (int j = 0; j < ch.GetLength(1); j++)
                {

                    Console.Write(ch[i, j]+" ");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char[,] ch = new char[4, 4];

            Pattern1.ShowPattern(ch);
        }
    }
}
