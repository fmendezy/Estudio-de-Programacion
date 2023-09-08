using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electro_FMY.Clases
{
    public class Refrigerador : Electrodomestico
    {
        public Refrigerador() : base() { }

        public bool EsSmart { get; set; }

        public override string Informacion()
        {
            string msg = EsSmart ? "Si" : "No";
           return base.Informacion() + " - Es smart: " + msg; 
        }
    }
}