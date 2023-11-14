using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    //public record ValidatedCart(ClientName name, Id id);
    public record ValidatedCart(ClientName Name, Id Id, Address Address, Code Code, Quantity Quantity);
}
