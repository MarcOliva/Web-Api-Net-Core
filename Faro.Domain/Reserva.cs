using System;

namespace Faro.Domain
{
    public class Reserva
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public string Comentario { get; set; }
        public int CantidadCama { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string FechaRegistro { get; set; }
        public double Descuento { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }
        public bool Anulado { get; set; }
    }
}