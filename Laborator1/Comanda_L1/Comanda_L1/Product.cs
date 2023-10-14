using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda_L1
{
    public class Product
    {
        public int ProductCode { get; }
        public Quantity Quantity { get; }

        public Product(int productCode, Quantity quantity)
        {
            ProductCode = productCode;
            Quantity = quantity;
        }
    }
}
