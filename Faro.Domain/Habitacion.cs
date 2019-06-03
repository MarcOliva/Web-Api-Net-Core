namespace Faro.Domain
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public EstadoHabitacion EstadoId { get; set; }
        public TipoHabitacion TipoHabitacionId { get; set; }
            
    }
}