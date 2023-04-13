using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    public class Cart
    {
        public int ProductID { get; private set; }
        
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

        public Cart(int productID, string productName, int quantity, double price, double total)
        {
            productID = ProductID;
            productName = ProductName;
            quantity = Quantity;
            price = Price;
            total = Total;
        }
    }
}
