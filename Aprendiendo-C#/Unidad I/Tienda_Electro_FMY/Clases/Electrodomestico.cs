using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electro_FMY.Clases
{
    public class Electrodomestico
    {
        public int  Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AniosGarantia { get; set; }


        public virtual string Informacion()
        {
            return $"ID: {Id} - Marca: {Marca} - Modelo: {Modelo} - Garantia: {AniosGarantia} Años.";
        }

    }
}
