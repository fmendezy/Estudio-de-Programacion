/* 
 * Creamos el array de "colores" 
 * Nota:los nombres están en minusculas ya que la busqueda es sensible a mayus y minus.
 */

List<string> colores = new List<string>();
colores.Add("rojo");
colores.Add("verde");
colores.Add("azul");
colores.Add("cafe");
colores.Add("celeste");
colores.Add("naranjo");

/* 
 * Buscando colores que contengan la letra "r"
 * Sin LINQ (Camino Largo) 
*/
List<string> Busqueda(string filter)
{
    List<string> resBusqueda = new List<string>();

    foreach (var color in colores)
    {
        if (color.Contains(filter))
            resBusqueda.Add(color);
    }
    return resBusqueda;
}

Console.WriteLine("-- SIN LINQ: Filtrando letra 'r' ---");
Busqueda("r").ForEach(x => Console.WriteLine(x));

Console.WriteLine(""); // Simple separación de ejercicios

/* 
 * Buscando colores que contengan la letra "f"
 * Con LINQ (Camino Corto) 
*/
List<string> BusquedaLinq(string filter)
{
    return colores.Where(x => x.Contains(filter)).ToList();
}

Console.WriteLine("--- CON LINQ: Filtrando letra 'f' ---");
BusquedaLinq("f").ForEach(x => Console.WriteLine(x));