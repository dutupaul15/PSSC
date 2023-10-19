using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public record Id
    {
        public decimal Value { get; }

        public Id(decimal value) 
        {
            if (value > 0)
            {
                Value = value;
            }
            else
            {
               Console.WriteLine($"{value:0.##} is an invalid grade value.");
            }
        }
    }
}
