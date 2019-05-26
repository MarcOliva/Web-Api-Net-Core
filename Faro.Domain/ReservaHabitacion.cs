namespace Faro.Domain
{
    public class ReservaHabitacion
    {
        public int Id { get; set; }
        public Reserva ReservaId { get; set; }
        public Habitacion HabitacionId { get; set; }
    }
}