using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Modelo
{
    public class Herramienta : Producto
    {
        public bool EsInalambrica {  get; set; }

        public override string Informacion()
        {
            string inalambrica = (EsInalambrica) ? "Si" : "No";
            return base.Informacion() + $"\nEs inalámbrica: {inalambrica}";
        }
    }
}
