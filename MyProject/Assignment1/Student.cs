using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Student
    {
        Student()
        {
          // this(5);
           Console.WriteLine("Default Chaining");
        }

        Student(int x)
        {
            //this(5, 12);
            Console.WriteLine(x);
        }

        Student(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Constructor Chaining : ");

            Student s = new Student();
            
        
            
        }
    }
}
