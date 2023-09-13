using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class VehiculoCollection
    {
        private static List<VehiculoEntity> _listadoVehiculo = new List<VehiculoEntity>();
        public static List<VehiculoEntity> ListadoVehiculo
        {
            get
            {
                return _listadoVehiculo;
            }
            set
            {
                _listadoVehiculo = value;
            }
        }
    }
}
