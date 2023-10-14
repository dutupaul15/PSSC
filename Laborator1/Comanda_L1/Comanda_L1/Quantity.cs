using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda_L1
{
    public class Quantity
    {
        public int Units { get; }
        public double Kilograms { get; }

        public Quantity(int units, double kilograms)
        {
            Units = units;
            Kilograms = kilograms;
        }

        public static Quantity InUnits(int units)
        {
            if (units < 0)
            {
                throw new ArgumentException("Cantitatea in unitati nu poate fi negativa.");
            }

            return new Quantity(units, 0);
        }

        public static Quantity InKilograms(double kilograms)
        {
            if (kilograms < 0)
            {
                throw new ArgumentException("Cantitatea in kilograme nu poate fi negativa.");
            }

            return new Quantity(0, kilograms);
        }
    }
}
