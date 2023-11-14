using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public class Product
    {
        public string code;
        public int quantity;

        public Product(string code, int quantity)
        {
            this.code = code;
            this.quantity = quantity;
        }
        
        public string Code { get { return code; } }
        public int Quantity { get { return quantity;} }

        public override string ToString()
        {
            return $"Code: {this.code}, Qunatity: {this.quantity}";
        }

    }
}
