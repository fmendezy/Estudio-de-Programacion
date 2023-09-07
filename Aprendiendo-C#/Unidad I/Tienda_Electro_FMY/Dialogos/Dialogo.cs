using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Electro_FMY.Clases;
using Tienda_Electro_FMY.List;

namespace Tienda_Electro_FMY.Dialogos
{
    public class Dialogo
    {
        public static void CargarDialogoCreate()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR NUEVO ELECTRODOMESTICO");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese la marca del producto");
            string? marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del producto");
            string? modelo = Console.ReadLine();
            Console.WriteLine("Ingrese años de garantia");
            int anioGtia = Convert.ToInt32(Console.ReadLine());

            Electrodomestico electro = new Electrodomestico()
            {
                Marca = marca,
                Modelo = modelo,
                AniosGarantia = anioGtia
            };
            Console.WriteLine(ElectrodomesticoCollection.Create(electro));
        }
        public static void CargarDialogoRead()
        {
            Console.Clear();
            Console.WriteLine("OBTENER PRODUCTO POR ID");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese el id del producto a buscar");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ElectrodomesticoCollection.Read(id));
        }
        public static void CargarDialogoUpdate()
        {
            Console.Clear();
            Console.WriteLine("ACTUALIZAR ELECTRODOMESTICO");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese el id del producto a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva marca del producto");
            string? marca = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo modelo del producto");
            string? modelo = Console.ReadLine();
            Console.WriteLine("Ingrese nuevos años de garantía");
            int aniosGtia = Convert.ToInt32(Console.ReadLine());

            Electrodomestico electro = new Electrodomestico()
            {
                Marca = marca,
                Modelo = modelo,
                AniosGarantia = aniosGtia
            };

            Console.WriteLine(ElectrodomesticoCollection.Update(id, electro));
        }
        public static void CargarDialogoDelete()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR PRODUCTO POR ID");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese el id del producto a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ElectrodomesticoCollection.Delete(id));
        }

        public static void CargarDialogoSearch()
        {
            Console.Clear();
            Console.WriteLine("BÚSQUEDA POR FILTRO");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese el parámetro de búsqueda");
            string? filter = Console.ReadLine();

            var res = ElectrodomesticoCollection.Search(filter);

            if (res.Count == 0) Console.WriteLine($"No existen registros con el valor: {filter}");
            else
            {
                res.ForEach(x =>
                {
                    Console.WriteLine(x.Informacion());
                });
            }
        }

        public static void CargarDialogoReadAll()
        {
            Console.Clear();
            Console.WriteLine("LISTAR TODOS LOS PRODUCTOS");
            Console.WriteLine("==================================================");

            var res = ElectrodomesticoCollection.ReadAll();

            if (res.Count == 0) Console.WriteLine("Agregue un registro para empezar a listar :c");
            else
            {
                res.ForEach(x =>
                {
                    Console.WriteLine(x.Informacion());
                });
            }
        }

    }
}
