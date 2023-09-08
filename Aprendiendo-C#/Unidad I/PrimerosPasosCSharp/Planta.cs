using System;


/*
Console.WriteLine("Laica");
var edad = 29;
Console.WriteLine($"Tu edad es {edad}");
string cancionFavorita = "Inmortal";
//Console.WriteLine("Mi cancion favorita es " + cancionFavorita);
string actividadCinco = "Mi cancion favorita es " + cancionFavorita;
string banda = "Tete Novoa";
int duracion = 360;
Console.WriteLine(actividadCinco + " de " + banda + " y dura " + duracion + " segundos.");

Console.WriteLine("\n ***********\n");

//int id = 0001;
string producto = "Notebook";
int valor = 599990;
bool estaDisponible = true;
Console.WriteLine("ID: " + id + "\nProducto: " + producto + "\nValor: $" + valor + "\nStock: " + (estaDisponible ? "Si" : "No"));

Console.WriteLine("\n ***********\n");
*/

/*
 * Clase
 */
public class Planta
{
    // Propiedades
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string NombreCientifico { get; set; }
    public bool esDeSombra { get; set; }
    public DateTime Plantada { get; set; }


    // Metodo
    public string Informacion()
    {
        string mensaje =  string.Format("Información planta ID: {0} - {1}\n \nNombre Cientifico: {2}\nTipo iluminación: {3}\nPlantada el: {4:dd-MM-yyyy}", Id, Nombre, NombreCientifico, esDeSombra ? "Sol" : "Sombra",Plantada);
        return mensaje;
    }

    // Constructor
    public Planta(int Id, string Nombre, string NombreCientifico, bool esDeSombra, DateTime Plantada)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.NombreCientifico = NombreCientifico;
        this.esDeSombra = esDeSombra;
        this.Plantada = Plantada;
    }
}

// Programa
/*
class Program
{
    static void Main(string[] args)
    {
         // Creación de objeto
        Planta Aloevera = new Planta(1, "Aloevera", "Aloeverus Cardianus", false, new DateTime(2023, 5, 12));

        // Invocacion del objeto
        Console.WriteLine(Aloevera.Informacion());
    }
}
*/