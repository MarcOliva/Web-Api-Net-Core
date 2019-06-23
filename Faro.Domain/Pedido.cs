using System.Collections.Generic;

namespace Faro.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<DetallePedido> DetallePedido { get; set; }
    }
}