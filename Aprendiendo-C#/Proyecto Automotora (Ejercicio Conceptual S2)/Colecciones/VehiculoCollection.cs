using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Clases;

namespace Proyecto_Automotora__Ejercicio_Conceptual_S2_.Colecciones
{
    /* Inicio codigo del ejercicio */
    public static class VehiculoCollection
    {
        private static List<Vehiculo> _listadoVehiculos = new List<Vehiculo>();

        /* Método Create() */
        public static string Create(Vehiculo v)
        {
            var res = _listadoVehiculos.Find(x => x.Modelo == v.Modelo);

            if (res != null)
                return "Vehiculo existente";

            v.Id = _listadoVehiculos.Count + 1;
            _listadoVehiculos.Add(v);

            return "Vehiculos agregado con éxito";
        }

        /* Método Read() */
        public static string Read(int id)
        {
            var res = _listadoVehiculos.Find(x => x.Id == id);

            if (res == null)
                return $"Vehículo con Id: {id} no encontrado";

            return res.InfoVehiculo();
        }

        /* Método Update() */
        public static string Update(int id, string marca, string modelo)
        {
            var res = _listadoVehiculos.Find(x => x.Id == id);
            if (res == null)
                return $"Vehiculo con Id: {id} no encontrado";

            res.Marca = marca;
            res.Modelo = modelo;

            return "Vehiculo actualizado\n" + res.InfoVehiculo();
        }

        /* Método Delete() */
        public static string Delete(string modelo)
        {
            var res = _listadoVehiculos.Find(x => x.Modelo == modelo);

            if (res == null)
                return $"Vehículo con Modelo: {modelo} no encontrado";

            _listadoVehiculos.Remove(res);
            return "Vehículo eliminado con éxito.";
        }

        /* Método ReadAll() */
        public static List<Vehiculo> ReadAll()
        {
            return _listadoVehiculos;
        }

        /* 
         * Método Search() 
         * Agrego != null antes del uso de Contains para evitar advertencias.
         */
        public static List<Vehiculo> Search(string filter)
        {
            return _listadoVehiculos.Where(x =>
                x.Modelo != null && x.Modelo.Contains(filter) ||
                x.Marca != null && x.Marca.Contains(filter)
                ).ToList();
        }

    }// fin
}
