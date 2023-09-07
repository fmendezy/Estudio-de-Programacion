

using Tienda_Electro_FMY.Clases;
using Tienda_Electro_FMY.Dialogos;
using Tienda_Electro_FMY.List;
/*
 * PRUEBA DEL EJERCICIO 1
 */
void EJ1()
{
    // Creación de la instancia Refrigerador
    Refrigerador Refri = new Refrigerador()
    {
        Id = 1,
        Marca = "Midea",
        Modelo = "MOD2023",
        AniosGarantia = 1
    };
    Console.WriteLine(Refri.Informacion());


    Refri.EsSmart = true;
    Console.WriteLine(Refri.Informacion());

}

/*
 * PRUEBA DEL EJERCICIO 3
 */
void EJ3()
{
    Console.WriteLine("*** \x1b[31mPROBANDO: CREATE \x1b[37m***");
    Refrigerador refri_nuevo_1 = new Refrigerador()
    {
        Id = 1,
        Marca = "Samsung",
        Modelo = "SAM1213123123123",
        AniosGarantia = 10,
        EsSmart = true
    };

    // Para los desarrollos
    Refrigerador refri_nuevo_2 = new Refrigerador()
    {
        Id = 2,
        Marca = "Midea",
        Modelo = "DEA-ARTSER7826",
        AniosGarantia = 2,
        EsSmart = false
    };

    Refrigerador refri_nuevo_3 = new Refrigerador()
    {
        Id = 3,
        Marca = "Fensa",
        Modelo = "FEN099898978",
        AniosGarantia = 1,
        EsSmart = false
    };

    Refrigerador refri_nuevo_4 = new Refrigerador()
    {
        Id = 3,
        Marca = "Madensa",
        Modelo = "TR11122334455666",
        AniosGarantia = 3,
        EsSmart = true
    };

    Console.WriteLine(ElectrodomesticoCollection.Create(refri_nuevo_1));// Dirá: Electrodomestico agregado exitosamente.
    Console.WriteLine(ElectrodomesticoCollection.Create(refri_nuevo_2));// Dirá: Electrodomestico agregado exitosamente.
    Console.WriteLine(ElectrodomesticoCollection.Create(refri_nuevo_3));// Dirá: Electrodomestico agregado exitosamente.
    Console.WriteLine(ElectrodomesticoCollection.Create(refri_nuevo_4));// Dirá: Electrodomestico agregado exitosamente.

    Console.WriteLine(ElectrodomesticoCollection.Create(refri_nuevo_1));// Dirá: Registro existente. (dado que se repite arriba)


    Console.WriteLine("\n***\x1b[31m PROBANDO: READ \x1b[37m***");
    Console.WriteLine(ElectrodomesticoCollection.Read(1));// Dará los datos del refri
    Console.WriteLine(ElectrodomesticoCollection.Read(5));// No existe registro


    Console.WriteLine("\n***\x1b[31m PROBANDO: UPDATE \x1b[37m***");
    Electrodomestico electro = new Electrodomestico()
    {
        Marca = "LG",
        Modelo = "L9888898",
        AniosGarantia = 2
    };
    Console.WriteLine(ElectrodomesticoCollection.Update(1, electro));// Electrodoméstico actualizado con éxito
    Console.WriteLine(ElectrodomesticoCollection.Read(1));// Revisión del cambio
    Console.WriteLine(ElectrodomesticoCollection.Update(5, electro));// Electrodomestico no existe o id incorrecto


    Console.WriteLine("\n***\x1b[31m PROBANDO: DELETE \x1b[37m***");
    Console.WriteLine(ElectrodomesticoCollection.Delete(1));// Eliminado con éxito
    Console.WriteLine(ElectrodomesticoCollection.Read(1));// No existe registro


    Console.WriteLine("\n***\x1b[31m PROBANDO: SEARCH \x1b[37m***");
    var buscar_1 = ElectrodomesticoCollection.Search("ide");// Buscar palabra 'ide'
    if (buscar_1.Count == 0) Console.WriteLine("Resultados de búsqueda: '0' registros.");
    else 
    {
        buscar_1.ForEach(x => Console.WriteLine(x.Informacion()));
    }

    var buscar_2 = ElectrodomesticoCollection.Search("G");// Buscar letra G (dará error)
    if (buscar_2.Count == 0) Console.WriteLine("Resultados de búsqueda: '0' registros.");
    else
    {
        buscar_2.ForEach(x => Console.WriteLine(x.Informacion()));//Resultados de búsqueda: '0' registros.
    }

    Console.WriteLine("\n***\x1b[31m PROBANDO: READALL \x1b[37m***");
    var leer = ElectrodomesticoCollection.ReadAll();// Buscar palabra 'ide'
    if (leer.Count == 0) Console.WriteLine("registros a mostrar");
    else
    {
        leer.ForEach(x => Console.WriteLine(x.Informacion()));
    }

}

/*
 * DESABILITAR 
 * UNO QUITANDO LOS "//" PARA PROBAR
 */
//EJ1();// Ejercicios 1
//EJ3();// Ejercicios 3 (el 2 es crear los metodos, aqui es probarlos)

/*
 * DESARROLLO FINAL: EJERCICIO 4
 */
void Presentacion()
{
    Console.WriteLine("BIENVENIDO!!!");
    Console.WriteLine("Elige una de las siguientes opciones para empezar");
    Console.WriteLine("1. Agregar nuevo electrodoméstico");
    Console.WriteLine("2. Buscar electrodoméstico por id");
    Console.WriteLine("3. Actualizar electrodoméstico");
    Console.WriteLine("4. Eliminar electrodoméstico");
    Console.WriteLine("5. Búsqueda personalizada");
    Console.WriteLine("6. Listar todos los registros");
    Console.WriteLine("0. Salir");

    Console.WriteLine("Ingrese opción");
}


void Reiniciar()
{
    Console.WriteLine("Presione una tecla para volver al menú");
    Console.ReadLine();
    Console.Clear();
    EJ4();
}

void Despedida()
{
    Console.Clear();
    Console.WriteLine("HASTA PRONTO!!");
    Console.WriteLine("Presiona cualquier tecla para salir");
    Console.ReadLine();
    Environment.Exit(1);
}

void EJ4()
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
                    Dialogo.CargarDialogoCreate();
                    Reiniciar();
                    break;

                case 2:
                    Dialogo.CargarDialogoRead();
                    Reiniciar();
                    break;

                case 3:
                    Dialogo.CargarDialogoUpdate();
                    Reiniciar();
                    break;

                case 4:
                    Dialogo.CargarDialogoDelete();
                    Reiniciar();
                    break;

                case 5:
                    Dialogo.CargarDialogoSearch();
                    Reiniciar();
                    break;

                case 6:
                    Dialogo.CargarDialogoReadAll();
                    Reiniciar();
                    break;

                case 0:
                    Despedida();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opción inválida");
                    Reiniciar();
                    break;
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Opción inválida");
        Reiniciar();
    }
}


EJ4();