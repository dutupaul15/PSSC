using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    internal class Product
    {
        public string code, address;
        public int quantity;

        public Product(string code, string address, int quantity)
        {
            this.code = code;
            this.address = address;
            this.quantity = quantity;
        }
        
        public string Code { get { return code; } }
        public string Address { get { return address; } }
        public int Quantity { get { return quantity;} }

        public override string ToString()
        {
            return $"Code: {this.code}, Address: {this.address}, Qunatity: {this.quantity}";
        }

    }
}
