using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// WAP display those wmployee who got salary more than 25000

namespace MyProject.Array
{
    class EmployeeDemo
    {
        int id;
        string name;
       internal double sal;

          public EmployeeDemo(int id,string name,double sal)
          {
            this.id = id;
            this.name = name;
            this.sal = sal;
            
          }
        public override string ToString()
        {
            return id + " " + name + " " +sal;

        }
    }

    internal class EmployeeSal
    {

        static void Main(string[] args)
        {

            EmployeeDemo[] d = new EmployeeDemo[10];

            Console.WriteLine("Enter Employee Detail : ");
            Console.WriteLine(" ");
            Console.WriteLine(".........................");

            for (int i = 0;i<d.Length;i++)
            {
                Console.WriteLine("Employee number is = " +i);
                Console.WriteLine(" ");

                Console.Write("Enter employee id : ");
                int eid = int.Parse(Console.ReadLine());
                Console.Write("Enter employee name : ");
                string ename = Console.ReadLine();
                Console.Write("Enter employee sal : ");
                double esal = double.Parse(Console.ReadLine());

                d[i] = new EmployeeDemo(eid, ename, esal);
                Console.WriteLine(".........................");

                Console.WriteLine(" ");

            }

            for(int i = 0;i<d.Length;i++)
            {
                Console.WriteLine(d[i]);
            }

            Console.WriteLine(".........................");

            foreach(EmployeeDemo emp in d)
            {
                if(emp.sal>25000)
                {
                    
                    Console.WriteLine(emp);

                }
                

               
            }


        }

            
            

            
    }
}
