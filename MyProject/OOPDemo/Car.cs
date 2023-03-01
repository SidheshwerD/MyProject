using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
    internal class Car
    {
        int mnum;
        string name;
        
        public void Input(int mnum , string cname)
        {
           this.mnum = mnum;
            name = cname; 
            // this.Display();
            Display();
        }
        public void Display()
        {
            Console.WriteLine(mnum);
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            Car c = new Car();
            c.Input(101 ,"Rahul");
            //c.Display();
        }
    }
}
