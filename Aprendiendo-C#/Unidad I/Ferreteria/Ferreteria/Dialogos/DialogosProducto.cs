using Ferreteria.Colecciones;
using Ferreteria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Dialogos
{
    public static class DialogosProducto
    {
        public static void CargarDialogoCreate()
        {
            Console.Clear();

            Console.WriteLine("AGREGAR NUEVO PRODUCTO");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Ingrese el nombre del producto");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el fabricante");
            string? fabricante = Console.ReadLine();

            Console.WriteLine("Ingrese la descripcion del producto");
            string? descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el precio");
            int precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Tiene descuento el Producto?\n-> 1. Si\n-> 2. No");
            int tieneDescuento = Convert.ToInt32(Console.ReadLine());

            bool hasDiscount;
            int descuento = 0;

            if(tieneDescuento == 1) {
                hasDiscount = true;
                Console.WriteLine("Ingrese descuento (porcentaje)");
                descuento = Convert.ToInt32(Console.ReadLine());
            }
            else
                hasDiscount = false;

            Console.WriteLine("¿Es Herramienta?\n-> 1. Si\n-> 2. No");
            int EsHerramienta = Convert.ToInt32(Console.ReadLine());

            if(EsHerramienta == 1)
            {// Entrada a caso herramienta
                Console.WriteLine("¿Es Inalambrica?\n-> 1. Si\n-> 2. No");
                int EsInalambrica = Convert.ToInt32(Console.ReadLine());

                bool isWireless;

                if(EsInalambrica == 1) 
                    isWireless = true;
                else
                    isWireless = false;

                Herramienta nuevoProducto = new Herramienta()
                {
                    Nombre = nombre,
                    Fabricante = fabricante,
                    Descripcion = descripcion,
                    Precio = precio,
                    TieneDescuento = hasDiscount,
                    Descuento = descuento,
                    EsInalambrica = isWireless
                };

                Console.WriteLine(ProductoCollection.Create(nuevoProducto) + "\n");
            }// FIN HERRAMIENTA

            // En el caso que NO SEA herramienta entra aqui
            else if(EsHerramienta >= 2)
            {
                Producto nuevaNoHerramienta = new Producto()
                {
                    Nombre = nombre,
                    Fabricante = fabricante,
                    Descripcion = descripcion,
                    Precio = precio,
                    TieneDescuento = hasDiscount,
                    Descuento = descuento,
                };

                Console.WriteLine(ProductoCollection.Create(nuevaNoHerramienta) + "\n");
            }
        }

        public static void CargarDialogoRead() 
        { 
            Console.Clear();

            Console.WriteLine("OBTENER PRODUCTO POR ID");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Ingrese el ID del producto:");
            string? id = Console.ReadLine();

            Console.WriteLine(ProductoCollection.Read(id) + "\n");
        }

        public static void CargarDialogoUpdate()
        {
            Console.Clear();
            Console.WriteLine("ACTUALIZAR PRODUCTO");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Ingrese el ID del producto a actualizar:");
            string? id = Console.ReadLine();

            Console.WriteLine("¿El producto tendrá descuento? (Indique opcion numerica)\n1. Si\n2. No");
            int tieneDescuento = Convert.ToInt32(Console.ReadLine());

            if(tieneDescuento == 1)
            {
                Console.WriteLine("Ingrese el procentaje de descuento (solo número)");
                int descuento = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine(ProductoCollection.Update(id, true, descuento) + "\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El producto no tendrá descuento.");
                Console.WriteLine(ProductoCollection.Update(id, false, 0) + "\n");
            }
        }

        public static void CargarDialogoDelete()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR PRODUCTO");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Ingrese el ID del producto a eliminar:");
            string? id = Console.ReadLine();

            Console.WriteLine(ProductoCollection.Delete(id) + "\n");
        }

        public static void CargarDialogoReadAll()
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE PRODUCTOS");
            Console.WriteLine("************************************\n");

            var res = ProductoCollection.ReadAll();
            if (res.Count == 0)
                Console.WriteLine("No existen registros a mostrar.");
            else
            {
                res.ForEach(x => { Console.WriteLine(x.Informacion() + "\n"); });

            }
        }

        public static void CargarDialogoSearch()
        {
            Console.Clear();
            Console.WriteLine("BÚSQUEDA AVANZADA DE PRODUCTOS");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Ingrese el filtro de búsqueda");
            string? filtro = Console.ReadLine();

            Console.WriteLine();

           var res = ProductoCollection.Search(filtro);

            if (res.Count == 0)
                Console.WriteLine($"No existen registros con el filtro '{filtro}'." + "\n");
            else
            {
                Console.WriteLine($"Coincidencias encontradas con el filtro '{filtro}': {res.Count}");
                res.ForEach(x => { Console.WriteLine(x.Informacion() + "\n"); });
            }
        }
    }
}
