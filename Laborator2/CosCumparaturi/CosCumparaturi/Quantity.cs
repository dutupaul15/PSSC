using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record Quantity
    {
        public int Value { get; }

        private Quantity(int value)
        {
            if (value == 0 || value > 1000)
            {
                throw new InvalidQuantityException("The quantity value must be between 0 and 1000!");
            }
            else
            {
                Value = value;
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
