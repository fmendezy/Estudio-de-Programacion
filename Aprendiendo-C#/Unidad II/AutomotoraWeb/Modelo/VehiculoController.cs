using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class VehiculoController
    {
        /*
         * CREATE
         */
        public static string Create(Vehiculo v)
        {
            var res = VehiculoCollection.ListadoVehiculo.Find(x => x.VIN == v.VIN);
            if (res != null)
                return "Vehiculo existente";

            VehiculoEntity entity = new VehiculoEntity()
            {
                Marca = v.Marca.ToUpper(),
                Modelo = v.Modelo.ToUpper(),
                Anio = v.Anio,
                VIN = v.VIN,
                EsElectrico = v.EsElectrico
            };

            VehiculoCollection.ListadoVehiculo.Add(entity);
            return $"Vehiculo con VIN {v.VIN} agregado con éxito!";
        }

        /*
         * READ
         */
        public static Vehiculo Read(string vin)
        {
            var res = VehiculoCollection.ListadoVehiculo.Find(x => x.VIN == vin);
            if (res == null) return null;

            Vehiculo v = new Vehiculo()
            {
                Id = res.id,
                Marca = res.Marca,
                Modelo = res.Modelo,
                Anio = res.Anio,
                VIN = res.VIN,
                EsElectrico = res.EsElectrico,
                CreatedAt = res.RetornarCreatedAt()
            };
            return v;
        }

        /*
         * UPDATE
         */
        public static string Update(string vin, string marca, string modelo)
        {
            var res = VehiculoCollection.ListadoVehiculo.Find(x => x.VIN == vin);
            if (res == null) return $"Vehiculo con ID: {vin} no encontrado";

            res.Marca = marca.ToUpper();
            res.Modelo = modelo.ToUpper();
            return $"Vehiculo con VIN {vin} actualizado exitosamente.";
        }


        /*
         * DELETE
         */
        public static string Delete(string vin)
        {
            var res = VehiculoCollection.ListadoVehiculo.Find(x =>x.VIN == vin);
            if (res == null) return $"Vehiculo con VIN: {vin} no encontrado";

            VehiculoCollection.ListadoVehiculo.Remove(res);
            return $"Vehiculo con VIN {vin} eliminado correctamente.";
        }

        /*
         * READALL
         */
        public static List<Vehiculo> ReadAll()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            VehiculoCollection.ListadoVehiculo.ForEach(x =>
            {
                Vehiculo v = new Vehiculo()
                {
                    Id = x.id,
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    Anio = x.Anio,
                    VIN = x.VIN,
                    EsElectrico = x.EsElectrico,
                    CreatedAt = x.RetornarCreatedAt()
                };

                vehiculos.Add(v);
            });

            return vehiculos;
        }

        /*
         * SEARCH
         */
        public static List<Vehiculo> Search(string filter)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            VehiculoCollection.ListadoVehiculo.Where(x =>
                x.Modelo.Contains(filter) ||
                x.Marca.Contains(filter) ||
                x.VIN.Contains(filter))
                .ToList()
                .ForEach(x => { 
         
                    Vehiculo v = new Vehiculo()
                    {
                        Id = x.id,
                        Marca = x.Marca,
                        Modelo = x.Modelo,
                        Anio = x.Anio,
                        VIN = x.VIN,
                        EsElectrico = x.EsElectrico,
                        CreatedAt = x.RetornarCreatedAt()
                    };
                    vehiculos.Add(v);
                });
            return vehiculos;
        }

    }
}
