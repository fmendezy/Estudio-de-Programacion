using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VehiculoEntity
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string VIN { get; set; } = string.Empty;
        public bool EsElectrico { get; set; }
        private DateTime _createdAt = DateTime.Now;

        public DateTime RetornarCreatedAt()
        {
            return _createdAt;
        }

    }
}
