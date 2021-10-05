using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculadora.ws
{
    public class calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public double radio;

        public decimal cuadrado()
        {
            return numero1 * numero2;
        }

        public decimal triangulo (decimal n1 ,decimal n2)
        {
            return (n1*n2)/2;
        }

        public double circulo ( double n1)
        {
         radio= n1* n1;
            return radio * 3.1416;
        }

    }
}