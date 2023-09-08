using Ferreteria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Colecciones
{
    public static class ProductoCollection
    {
        private static List<Modelo.Producto> _listadoHerramientas = new List<Modelo.Producto>();

        public static string Create(Producto p)
        {
            var res = _listadoHerramientas.Find(x => x.Nombre == p.Nombre);
            if (res != null) return "Producto existente";

            _listadoHerramientas.Add(p);
            return $"Producto con ID {p.ID} agregado con éxito.";
        }

        public static string Read(string id)
        {
            var res = _listadoHerramientas.Find(x => x.ID == id);

            if (res == null) return $"Producto con ID {id} no pudo ser encontrado.";

            return "\n" + res.Informacion();
        }

        public static string Update(string id, bool tieneDescuento, int descuento)
        {
            var res = _listadoHerramientas.Find(x => x.ID == id);
            if (res == null) return $"Producto con ID {id} no pudo ser encontrado.";

            res.TieneDescuento = tieneDescuento;
            res.Descuento = descuento;

            return $"Producto con ID {id} actualizado con exito \n\n" + res.Informacion();
        }

        public static string Delete(string id)
        {
            var res = _listadoHerramientas.Find(x => x.ID == id);
            if (res == null) return $"Producto con ID {id} no pudo ser encontrado.";

            _listadoHerramientas.Remove(res);
            return $"Producto con ID {id} eliminado correctamente";
        }

        public static List<Producto> ReadAll()
        {
            return _listadoHerramientas;
        }

        public static List<Producto> Search(string filter)
        {
            return _listadoHerramientas.Where(
                x => x.Nombre.Contains(filter) ||
                x.Fabricante.Contains(filter)).ToList();
        }

    }
}
