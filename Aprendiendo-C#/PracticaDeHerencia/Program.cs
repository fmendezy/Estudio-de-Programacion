using PracticaDeHerencia.Clases;

class Program
{
    static void Main(string[] args)
    {
        // CONSTRUCTOR

        // Opcion de crear objeto numero 1
        Hija Alicia = new Hija()
        {
            Nombre = "Alicia",
            Edad = 8
        };

        Alicia.QuieroSaberSiPuedoEntrar();

        Console.WriteLine("**********");

        // Opcion de crear objeto numero 2
        Hija Alicia_2 = new Hija();
        Alicia_2.Nombre = "Alicia_2";
        Alicia_2.Edad = 8;
        Alicia_2.QuieroSaberSiPuedoEntrar();
    }
}