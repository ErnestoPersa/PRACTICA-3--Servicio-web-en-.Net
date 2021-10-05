using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculadora.ws
{
    /// <summary>
    /// Descripción breve de Calcularwebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcularwebservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadrado(decimal n1, decimal n2)
        {
            calcular c = new calcular();
            c.numero1 = n1;
            c.numero2 = n2;
            return c.cuadrado();
        }

        [WebMethod]
        public decimal triangulo(decimal n1, decimal n2)
        {
            calcular c = new calcular();
           
            return c.triangulo(n1,n2);
        }

        [WebMethod]
        public double circulo(double n1)
        {
            calcular c = new calcular();

            return c.circulo(n1);
        }
    }
}
