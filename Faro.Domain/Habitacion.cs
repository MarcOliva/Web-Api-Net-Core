namespace Faro.Domain
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoHabitacion Estado { get; set; }
        public TipoHabitacion TipoHabitacionId { get; set; }
            
    }
}