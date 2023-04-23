using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    public class Cart
    {
        
        public string ProductName { get;private set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    
        public double Total
        {
            get { return Quantity * Price; }
        }

        public Cart()
        {
            
        }

        public Cart(string productName, int quantity, double price, double total)
        {
            productName = ProductName;
            quantity = 1;
            price = Price;
        }
    }
}
