using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// write a code to check given number is vowel or consonant by using switch case statement.

namespace MyProject.Loop
{
    internal class Demo4
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write(" Enter any Character : ");
            ch = Convert.ToChar( Console.ReadLine());
            switch(ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':

                    Console.WriteLine($"\n\t{ch} is a Vowel ");
                    break;
                    default:
                    Console.WriteLine($"\n\t{ch} is  a Consonant ");
                    break;

            }
               Console.ReadLine();
        }
    }
}
