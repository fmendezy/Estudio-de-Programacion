using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeHerencia.Clases
{
    public class Padre
    {
        // Propiedades
        public string? Nombre { get; set; }
        public int? Edad {  get; set; }

        // Metodo
        protected void AccesoCasa()
        {
            Console.WriteLine($"{Nombre} de {Edad} años tiene acceso a la casa");
            //return $"{Nombre} de {Edad} tiene acceso a la casa";
        }
    }
}
