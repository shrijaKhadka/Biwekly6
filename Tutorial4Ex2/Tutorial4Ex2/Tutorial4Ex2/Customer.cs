using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutorial4Ex2
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        public Customer(int i, string n)
        {
            id = i;
            name = n;
        }

        public List<Product> shopList = new List<Product>();

    }
}
