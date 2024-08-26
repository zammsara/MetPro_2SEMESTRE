using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularRaiz.clases
{
    internal class Raiz
    {
        public double Num { get; set;  }

        public double calcularRaiz()
        {
            return Math.Sqrt(Num);
        }

        public Raiz() { }
    }
}
