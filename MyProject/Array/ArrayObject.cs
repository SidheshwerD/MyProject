using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Array
{
    class Employee
    {
        int empid;
        string empname;
        double empsal;



        public Employee(int empid, string empname, double empsal)
        {
            this.empid = empid;
            this.empname = empname;
            this.empsal = empsal;
        }
        public override string ToString()
        {
            return empid + " " + empname + " " + empsal;
           

        }
    }
    internal class ArrayObject
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "rahul", 18000);
            Console.WriteLine(e);
        }

    }
}
