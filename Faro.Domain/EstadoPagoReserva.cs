namespace Faro.Domain
{
    public class EstadoPagoReserva
    {
        public int Id { get; set; }
        public EstadoPago EstadoPagoId { get; set; }
        public Reserva ReservaId { get; set; }
    }
}