using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Tienda_Electro_FMY.Clases;

namespace Tienda_Electro_FMY.List
{
    public static class ElectrodomesticoCollection
    {
        private static List<Electrodomestico> _listadoElectro = new();

        /*
         * Metodos
         */

        /*
         *  CREATE
         */
        public static string Create(Electrodomestico electro)
        { 
            foreach (var busqueda in _listadoElectro)
            {
                if (busqueda.Modelo == electro.Modelo) return "Registro existente.";
            }
            electro.Id = _listadoElectro.Count + 1;
            _listadoElectro.Add(electro);
            return "Electrodomestico agregado exitosamente.";
        }

        /*
         * READ
         */
        public static string Read(int id)
        {
            var res = _listadoElectro.Find(x => x.Id == id);
            if (res == null) return "No existe registro";
            return res.Informacion();
        }

        /*
        * UPDATE
        */
        public static string Update(int id, Electrodomestico electro)
        {
            foreach(var item in _listadoElectro)
            {
                if (item.Id != id) return "Electrodomestico no existe o id incorrecto";
                item.Modelo = electro.Modelo;
                item.Marca = electro.Marca;
                item.AniosGarantia = electro.AniosGarantia;
                return "Electrodoméstico actualizado con éxito";
            }
            return "Ocurrio un problema al actualizar";
        }

        /*
         * DELETE
         */
        public static string Delete(int id, Electrodomestico electro)
        {
            var res = _listadoElectro.Find(x => x.Id == id);
            if (res == null) return "No existe registro";
            return _listadoElectro.Remove(res) ? "Eliminado con éxito" : "No se pudo eliminar registro";
        }

        /*
         * SEARCH
         */
        public static List<Electrodomestico> Search(string filter)
        {
           return _listadoElectro.Where(x => x.Marca.Contains(filter) || x.Modelo.Contains(filter)).ToList();
        }

        /*
         * READALL
         */
        public static List<Electrodomestico> ReadAll()
        {
            return _listadoElectro.ToList();
        }


    }
}
