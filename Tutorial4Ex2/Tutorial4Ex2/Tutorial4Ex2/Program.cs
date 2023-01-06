using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex2
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer cust1 = new Customer(101, "First Customer ");
            Customer cust2 = new Customer(102, "Second Customer");

            Console.WriteLine("ID of 1st Cusotmer: " + cust1.id);
            Console.WriteLine("Name of 2nd Customer: " + cust2.name);

            Product p1 = new Product();
            Product p2 = new Product();

            p1.id = 23;
            p1.price = 9.5;

            p2.id = 33;
            p2.price = 5.5;

            cust1.shopList.Add(p1);
            cust2.shopList.Add(p2);

            Console.Read();
        }
    }
}
