using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record Address
    {
        public string Value { get; }

        private Address(string value) => Value = value;
        public override string ToString()
        {
            return Value;
        }

    }
}
