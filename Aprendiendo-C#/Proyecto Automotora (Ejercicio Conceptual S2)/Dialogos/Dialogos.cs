using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Clases;
using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Colecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automotora__Ejercicio_Conceptual_S2_.Dialogos
{
    public static class Dialogos
    {
        /* Método para los Dialogos de Create() */
        public static void CargarDialogoCreate()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR NUEVO REGISTRO");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Ingrese la Marca del vehiculo:");
            string? marca = Console.ReadLine();

            Console.WriteLine("Ingrese el Modelo del vehiculo:");
            string? modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año de fabricación:");
            int anio = Convert.ToInt32(Console.ReadLine());// convierte de string (recibido) a int

            Console.WriteLine("Ingrese número del chasis (VIN)");
            string? VIN = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de motor\n1. Electrico\n2. Gasolina");
            int motor = Convert.ToInt32(Console.ReadLine());

            bool tipoMotor;

            if (motor == 1)
                tipoMotor = true;
            else if (motor == 2)
                tipoMotor = false;
            else
            {
                Console.WriteLine("Opción inválida. Por defecto se agregará como Electrico.");
                tipoMotor = true;
            }

            /* Creación del objeto con los datos recibidos */
            Auto auto = new Auto()
            {
                Marca = marca,
                Modelo = modelo,
                Anio = anio,
                VIN = VIN,
                EsElectrico = tipoMotor
            };

            Console.WriteLine(VehiculoCollection.Create(auto));
        }

        /* Método para los Dialogos de Read() */
        public static void CargarDialogoRead()
        {
            Console.Clear();
            Console.WriteLine("OBTENER VEHÍCULO POR ID");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Ingrese el id del vehiculo:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(VehiculoCollection.Read(id));
        }

        /* Método para los Dialogos de Update() */
        public static void CargarDialogoUpdate()
        {
            Console.Clear();
            Console.WriteLine("ACTUALIZAR VEHICULO");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Ingrese el id del vehiculo a actualizar:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva marca del vehiculo:");
            string? marca = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo modelo del vehículo:");
            string? modelo = Console.ReadLine();

            if (marca != null && modelo != null)
            {
                Console.WriteLine(VehiculoCollection.Update(id, marca, modelo));
            }
            else
            {
                Console.WriteLine("Marca y modelo no pueden estar vacíos, reintente.");
            }
        }

        /* Método para los dialogos de Delete() */
        public static void CargarDialogoDelete()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR VEHÍCULO");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Ingrese el modelo del vehículo a eliminar");
            string? modelo = Console.ReadLine();

            if (modelo != null)
            {
                Console.WriteLine(VehiculoCollection.Delete(modelo));
            }
            else
            {
                Console.WriteLine("Modelo no puede estar vacío, reintente.");
            }
        }

        /* Método para los dialos de ReadAll() */
        public static void CargarDialogoReadAll()
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE VEHÍCULOS");
            Console.WriteLine("***********************\n");

            var res = VehiculoCollection.ReadAll();

            if (res.Count == 0) Console.WriteLine("No existen registros.");
            else
            {
                res.ForEach(x =>
                {
                    Console.WriteLine(x.InfoVehiculo() + "\n");
                });

            }
        }

        /* Método para los dialosogs de Search() */
        public static void CargarDialogoSearch()
        {
            Console.Clear();
            Console.WriteLine("BÚSQUEDA AVANZADA");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Ingrese el parámetro de búsqueda");
            string? filtro = Console.ReadLine();

            if (filtro != null)
            {
                var res = VehiculoCollection.Search(filtro);

                if (res.Count == 0) Console.WriteLine("No existen registros.");
                else
                {
                    Console.WriteLine("Coincidencias encontradas: " + res.Count);
                    res.ForEach(x =>
                    {
                        Console.WriteLine(x.InfoVehiculo() + "\n");
                    });
                }
            }
            else
            {
                Console.WriteLine("El parámetro de búsqueda no puede ser nulo o no existe.");
            }
        }
    }// fin clase Dialogos
}
