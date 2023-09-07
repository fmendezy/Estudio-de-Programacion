using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automotora__Ejercicio_Conceptual_S2_.Clases
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Anio { get; set; }
        public string? VIN { get; set; }
        public bool EsElectrico { get; set; }
        private DateTime? _createdAt = DateTime.Now;

        public string InfoVehiculo()
        {
            return $"Id: {Id}\n" +
                   $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Anio}\n" +
                   $"VIN: {VIN}\n" +
                   $"Motor: {TipoMotor()}\n" +
                   $"Registro creado el: {_createdAt.ToString()}";
        }

        private string TipoMotor()
        {
            if (EsElectrico)
                return "Eléctrico";
            else
                return "Gasolina";
        }

        // Mod para poder acceder a fecha y crear objetos automaticos de ejemplo
        public void SetCreatedAt(DateTime fecha)
        {
            _createdAt = fecha;
        }

    }
}
