using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record ClientName
    {

        public string Value { get; }

        private ClientName(string value) => Value = value;
        public override string ToString()
        {
            return Value;
        }

    }
}
