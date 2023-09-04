using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Clases;
using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Colecciones;
using Proyecto_Automotora__Ejercicio_Conceptual_S2_.Dialogos;
using System.Collections;

void AppConcesionario()
{
        try
        {
            while (true)
            {
                Presentacion();
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Dialogos.CargarDialogoCreate();
                        Reiniciar();
                        break;

                    case 2:
                        Dialogos.CargarDialogoRead();
                        Reiniciar();
                        break;

                    case 3:
                        Dialogos.CargarDialogoUpdate();
                        Reiniciar();
                        break;

                    case 4:
                        Dialogos.CargarDialogoDelete();
                        Reiniciar();
                        break;

                    case 5:
                        Dialogos.CargarDialogoReadAll();
                        Reiniciar();
                        break;

                    case 6:
                        Dialogos.CargarDialogoSearch();
                        Reiniciar();
                        break;

                    case 0:
                        Despedida();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no valida, por favor, ingresa un numero valido.");
                        Reiniciar();
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Opción inválida");
            Reiniciar();
        }
}


void Presentacion()
{
        Console.WriteLine("¡Bienvenido a mi primer programa en C#!");
        Console.WriteLine("Autor: Francisco Mendezy (Frank)\n");
        Console.WriteLine("Elige una de las siguientes opciones para comenzar:");
        Console.WriteLine("1.- Agregar nuevo Vehículo");
        Console.WriteLine("2.- Buscar vehiculo por ID");
        Console.WriteLine("3.- Actualizar vehiculo");
        Console.WriteLine("4.- Eliminar vehiculo");
        Console.WriteLine("5.- Listar todos los registros");
        Console.WriteLine("6.- Búsqueda personalizada");
        Console.WriteLine("0. Salir");

        Console.WriteLine("\nEscriba el número de la opción.");
}

    /*  Limpiador de pantalla */
void Reiniciar()
    {
        Console.WriteLine("Presione una tecla para volver al menú");
        Console.ReadLine();
        Console.Clear();
        AppConcesionario();
}

    /* Despedida */
    void Despedida()
    {
        Console.Clear();
        Console.WriteLine("HASTA PRONTO!");
        Console.WriteLine("Presiona cualquier tecla para salir");
        Console.ReadLine();
        Environment.Exit(1);
    }

/*
 * Creación de 5 Vehiculos de Prueba
 */
Auto vehiculo1 = new Auto()
{
    Id = 1,
    Modelo = "Sedan",
    Marca = "Chevrolet",
    Anio = 2010,
    VIN = "SDA231165161",
    EsElectrico = false
};
VehiculoCollection.Create(vehiculo1);
//vehiculo1.SetCreatedAt(DateTime.Today);

Auto vehiculo2 = new Auto()
{
    Id = 2,
    Modelo = "SUV",
    Marca = "Ford",
    Anio = 2021,
    VIN = "FORD123456789",
    EsElectrico = true
};
//vehiculo2.SetCreatedAt(DateTime.Today);
VehiculoCollection.Create(vehiculo2);

Auto vehiculo3 = new Auto()
{
    Id = 3,
    Modelo = "Compacto",
    Marca = "Toyota",
    Anio = 2018,
    VIN = "TOY123456789",
    EsElectrico = false
};
//vehiculo3.SetCreatedAt(DateTime.Today);
VehiculoCollection.Create(vehiculo3);

Auto vehiculo4 = new Auto()
{
    Id = 4,
    Modelo = "Camioneta",
    Marca = "Nissan",
    Anio = 2019,
    VIN = "NISSAN123456",
    EsElectrico = false
};
//vehiculo4.SetCreatedAt(DateTime.Today);
VehiculoCollection.Create(vehiculo4);

Auto vehiculo5 = new Auto()
{ 
    Id = 5,
    Modelo = "Deportivo",
    Marca = "Ferrari",
    Anio = 2022,
    VIN = "FERRARI987654",
    EsElectrico = false
};
//vehiculo5.SetCreatedAt(DateTime.Today);
VehiculoCollection.Create(vehiculo5);

// Ejecutar codigo
AppConcesionario();