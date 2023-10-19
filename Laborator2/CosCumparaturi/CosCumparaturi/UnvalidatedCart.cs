using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record UnvalidatedCart(string ClientName, string Id, string Code, string Address, int Quantity);
}
