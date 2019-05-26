namespace Faro.Domain
{
    public class ReservaCliente
    {
        public string Responsable { get; set; }
        public Reserva ReservaId { get; set; }
        public Cliente ClienteId { get; set; }
      
    }
}