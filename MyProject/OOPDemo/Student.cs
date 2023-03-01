using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class Student
    {
        int sid;
        string sname;
        int m1, m2, m3,total,percentage;
        

        public void Details()
        {
            sid = 21;
            sname = "Rahul";
            m1 = 58;
            m2 = 86;
            m3 = 75;
        }
        public void Calculate()
        {
            total = m1 + m2 + m3;
            percentage = total / 3;
        }
        public void Display()
        {
            Console.Write (sid + "\n" + sname + "\n" + m1 + "\n" + m2 + "\n" + m3);
            Console.WriteLine("\npercentage  : " +percentage);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Details();
            s.Calculate();
            s.Display();
        }
    }
}
