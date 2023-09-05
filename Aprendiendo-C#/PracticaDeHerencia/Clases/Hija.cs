using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeHerencia.Clases
{
    public class Hija : Padre
    {
        public Hija() : base() { }// Codigo que permite acceder a la clase base/padre

        public void QuieroSaberSiPuedoEntrar()
        {
            AccesoCasa();
        }
    }
}
