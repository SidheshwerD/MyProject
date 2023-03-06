using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPDemo
{
   internal class Order
   {
        int oid, qty;
        Menu m;

        public Order(int oid, int qty, Menu m)
        {
            this.oid = oid;
            this.qty = qty;
            this.m = m;
        }

        public void show()
        {
            Console.WriteLine(oid + " " + qty);
            Menu m = new Menu(101, 260, "Veg Thali ");
          //  Display();
        }
   }
     class Menu
     {
        int mid, price;
        string item;
        

        public Menu(int mid,int price,string item)
        {
            this.mid = mid;
            this.price = price;
            this.item = item;

           void Display()
            {
                Console.WriteLine(mid + " " + price + " " + item);
            }

            static void Main(string[] args)
            {
                Menu m = new Menu(101, 260, "Veg Thali ");
                Order o = new Order(2, 2, m);
                o.show();
            }
        }
     }
}
