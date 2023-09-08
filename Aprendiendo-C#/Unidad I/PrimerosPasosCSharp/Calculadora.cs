using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosCSharp
{
    public class Calculadora
    {
        // Propiedades
        public int X { get; set; }
        public int Y { get; set; }
        private int _resultado { get; set; }

        // Metodos
        public int Calculos (string operacion)
        {
            try
            {// inicio try
                switch (operacion)
                {
                    case "s":
                        _resultado = X + Y;
                        break;
                    case "r":
                        _resultado = X - Y;
                        break;
                    case "m":
                        _resultado = X * Y;
                        break;
                    case "d":
                        _resultado = X / Y;
                        break;
                    default:
                        throw new Exception("Opción inválida");
                     
                }
            }// fin try
            catch (Exception ex)
            {
                Console.WriteLine("Se capturó una excepción: " + ex.Message);
            }

            return _resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora miCalculadora = new Calculadora(); // Crear una instancia de la clase Calculadora

            miCalculadora.X = 10; // Asignar valores a las propiedades X e Y
            miCalculadora.Y = 5;

            int suma = miCalculadora.Calculos("s"); // Llamar al método Calculos con la operación de suma
            int resta = miCalculadora.Calculos("r"); // Llamar al método Calculos con la operación de resta
            int multi = miCalculadora.Calculos("m");
            int divi = miCalculadora.Calculos("d");
            int invalida = miCalculadora.Calculos("k");

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " +  multi);
            Console.WriteLine("Divición: " + divi);
            Console.WriteLine("Invalida: " + invalida);
        }
    }
}