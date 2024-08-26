using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.clases
{
    internal class Area
    {
        public double Radio { get; set; }

        public double calcularArea()
        {
        return Math.PI * Math.Pow(Radio, 2);
        }

        public Area() { }

    }
}
