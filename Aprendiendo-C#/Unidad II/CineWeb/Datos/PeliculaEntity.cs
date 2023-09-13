using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PeliculaEntity
    {
        public string Id = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Idioma { get; set; }
        public int Duracion { get; set; }
        public int Valoracion { get; set; }
        public bool EsTodoPublico { get; set; }
        public bool EnCartelera { get; set; }
        public bool TieneSubtitulos { get; set; }
        public DateTime FechaEstreno { get; set; }

        private DateTime _createdAt = DateTime.Now;

        public DateTime RetornarCreatedAt()
        {
            return _createdAt;
        }
    }

}
