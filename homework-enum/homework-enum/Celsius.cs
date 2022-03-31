using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_enum
{
    class Celsius
    {

        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273.15);
        }

        
    }
}
