using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// WAP who got more than 60 percent

namespace MyProject.Array
{
    class Student
    {

        int id;
        string name;
        internal double marks,per;
        internal int m1, m2, m3;
        internal  int sum = 0;
       internal int total;


        public Student(int id, string name, double per)
        {
            this.id = id;
            this.name = name;
            //this.marks = marks;
            //this.m1 = m1;
            //this.m2 = m2;
            //this.m3 = m3;
            //this.total = total;

        }
        public override string ToString()
        {
            return id + " " + name + " " + marks;

        }
    }


    internal class StudentDemo
    {

        static void Main(string[] args)
        {

            Student[] s = new Student[5];

            Console.WriteLine("Enter Student Detail : ");
            Console.WriteLine(" ");
            Console.WriteLine(".........................");

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Student number is = " + i);
                Console.WriteLine(" ");

                Console.Write("Enter Student id : ");
                int sid = int.Parse(Console.ReadLine());
                Console.Write("Enter Student name : ");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter student marks : ");
                
                    for(int j =0;j<s.Length;j++)
                    {
                      Console.Write("m1 : ");
                      int m1 = int.Parse(Console.ReadLine());
                      Console.Write("m2 : ");
                      int m2 = int.Parse(Console.ReadLine());
                      Console.Write("m3 : ");
                      int m3 = int.Parse(Console.ReadLine());
                      int total = m1 + m2 + m3;
                      double per = total / 3;
                      Console.WriteLine("per : " + per);
                      break;

                   
                    }
                Console.WriteLine(" ");
                continue;
                Console.WriteLine(" ");
               

                //s[i] = new Student(sid, sname);
                Console.WriteLine(".........................");

                Console.WriteLine(" ");

            }

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine(".........................");

            foreach (Student st in s)
            {
                if(st.per > 60)
                {

                    Console.WriteLine(st);

                }



            }


        }





    }

}


