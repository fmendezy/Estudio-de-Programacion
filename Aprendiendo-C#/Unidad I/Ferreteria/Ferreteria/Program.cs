using Ferreteria.Colecciones;
using Ferreteria.Dialogos;
using Ferreteria.Modelo;

void AppFerreteria()
{
    try
    {
       while (true)
        {
            Bienvenida();
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    DialogosProducto.CargarDialogoCreate();
                    Reiniciar();
                    break;
                case 2:
                    DialogosProducto.CargarDialogoRead();
                    Reiniciar();
                    break;

                case 3:
                    DialogosProducto.CargarDialogoUpdate();
                    Reiniciar();
                    break;
                case 4:
                    DialogosProducto.CargarDialogoDelete();
                    Reiniciar();
                    break;
                case 5:
                    DialogosProducto.CargarDialogoReadAll();
                    Reiniciar();
                    break;
                case 6:
                    DialogosProducto.CargarDialogoSearch();
                    Reiniciar();
                    break;
                case 0:
                    Despedida();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opcion Inválida");
                    Reiniciar();
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Opcion Inválida");
        Reiniciar();
    }
}

void Bienvenida()
{
    Console.WriteLine("Bienvenido a la ferreteria Los Gallos");
    Console.WriteLine("Elige una opción del menú para empezar\n");
    Console.WriteLine("1. Agregar nuevo producto");
    Console.WriteLine("2. Buscar producto por id");
    Console.WriteLine("3. Actualizar producto");
    Console.WriteLine("4. Eliminar producto");
    Console.WriteLine("5. Listar todos los registro");
    Console.WriteLine("6. Búsqueda personalizada");
    Console.WriteLine("0. Salir");

    Console.WriteLine("\nIngrese una opción:");
}

void Despedida()
{
    Console.Clear();
    Console.WriteLine("¡HASTA PRONTO!");
    Console.WriteLine("Presiona cualquier tecla para Salir.");
    Console.ReadLine();
    Console.Clear();
    Environment.Exit(1);
}

void Reiniciar()
{
    Console.WriteLine("Presione una tecla para volver al menú");
    Console.ReadLine();
    Console.Clear();
    AppFerreteria();
}

void PreCargaRegistros()
{
    Producto p1 = new Producto()
    {
        Nombre = "Pintura al agua color rojo",
        Fabricante = "Ceresita",
        Descripcion = "Pintura al agua exterior de color rojo",
        Precio = 35500,
        TieneDescuento = true,
        Descuento = 5
    };

    Producto p2 = new Herramienta()
    {
        Nombre = "Desatornillador de paleta 3'4",
        Fabricante = "General Electric",
        Descripcion = "Desatornillador de paleta 3'4 de acero reforzado",
        Precio = 3500,
        TieneDescuento = false,
        Descuento = 0,
        EsInalambrica = true
    };

    Producto p3 = new Herramienta()
    {
        Nombre = "Taladro Percutor",
        Fabricante = "Bosh",
        Descripcion = "Taladro percutor multiuso con brocas de cementop, cerámica y madera",
        Precio = 120000,
        TieneDescuento = false,
        Descuento = 0,
        EsInalambrica = false
    };

    ProductoCollection.Create(p1);
    ProductoCollection.Create(p2);
    ProductoCollection.Create(p3);
}

PreCargaRegistros();
AppFerreteria();