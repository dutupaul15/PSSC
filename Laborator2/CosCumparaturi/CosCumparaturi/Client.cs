using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public class Client
    {
        public string name, id, address;
        public Client(string name, string id, string address)
        {
            this.name = name;
            this.id = id;
            this.address = address;
        }
    }
}
