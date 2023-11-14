using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record Code
    {
        private static readonly Regex ValidPattern = new("^QR[0-9]{4}$");

        public string Value { get; }

        private Code(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                throw new InvalidCodeException("The entered code does not respect CODE PATTERN!");
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
