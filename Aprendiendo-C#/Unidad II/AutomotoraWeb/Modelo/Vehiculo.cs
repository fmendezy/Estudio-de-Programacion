using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vehiculo
    {
        public string Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo {  get; set; } = string.Empty;
        public int Anio { get; set; }
        public string VIN { get; set; } = string.Empty;
        public bool EsElectrico { get; set; }
        public DateTime CreatedAt { get; set; }

        public string TipoMotor()
        {
            if (EsElectrico)
                return "Eléctrico";
            else
                return "Gasolina";
        }
    }
}
