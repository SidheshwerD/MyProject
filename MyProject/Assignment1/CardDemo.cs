using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    class Card
    {
        public static void doTransaction(string param)
        {

            if (param == "Creditcard")
            {
                Console.WriteLine("you got 15% discount on bill on creditcard transaction ");
            }
            //else (param == "Debitcard")
            {
                Console.WriteLine("No Discount on bill on debitcard transaction ");
            }
        }
       
    }
    internal class CardDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameter :");
            string param = Console.ReadLine();

            Card.doTransaction(param);
        }
    }
}
