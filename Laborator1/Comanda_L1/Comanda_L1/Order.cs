using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda_L1
{
    public class Order
    {
        public Contact Contact { get; }
        public List<Product> Products { get; }

        public Order(Contact contact, List<Product> products)
        {
            Contact = contact ?? throw new ArgumentNullException(nameof(contact));
            Products = products ?? throw new ArgumentNullException(nameof(products));
        }
    }
}
