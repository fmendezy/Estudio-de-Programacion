using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class PeliculaCollection
    {
        private static List<PeliculaEntity> _listadoPeliculas = new List<PeliculaEntity>();

        public static List<PeliculaEntity> ListadoPeliculas
        {
            get { return _listadoPeliculas; }
            set { _listadoPeliculas = value; }
        }
    }

}
