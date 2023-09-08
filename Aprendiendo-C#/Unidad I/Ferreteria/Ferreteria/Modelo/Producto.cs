using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Modelo
{
    public class Producto
    {
        public string ID = Guid.NewGuid().ToString();
        public string? Nombre {  get; set; }
        public string? Fabricante { get; set; }
        public string? Descripcion { get; set; }
        public int Precio { get; set; }
        public bool TieneDescuento { get; set; }
        public int Descuento { get; set; }
        private DateTime _createdAt = DateTime.Now;

        public virtual string Informacion()
        {
            string message =
                $"ID: {ID}\n" +
                $"Nombre: {Nombre}\n" +
                $"Fabricante: {Fabricante}\n" +
                $"Descripción: {Descripcion}\n" +
                $"Precio: {Precio}\n" +
                $"Ingresado el: {_createdAt}\n";

            if(TieneDescuento)
            {
                message +=
                    $"Tiene descuento: Si\n" +
                    $"Descuento: {Descuento}";
            }
            return message;
        }
    }
}