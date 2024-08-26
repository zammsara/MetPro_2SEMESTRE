
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCubo.clases
{
    internal class Cubo
    {
        public double Num { get; set; }  
        
        public double calcularCubo() 
        {
            return Math.Pow(Num, 3);
        }
        public Cubo () { }
    }
}
