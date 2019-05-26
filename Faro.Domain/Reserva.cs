using System;

namespace Faro.Domain
{
    public class Reserva
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public string Comentario { get; set; }
        public int CantidadCama { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public double Descuento { get; set; }
        public TipoReserva TipoReservaId { get; set; }
        public Moneda MonedaId { get; set; }
        public TipoComprobante TipoComprobanteId { get; set; }
        public MetodoPago MetodoPagoId { get; set; }
        public Empleado EmpleadoId { get; set; }
        public bool Anulado { get; set; }

    }
}