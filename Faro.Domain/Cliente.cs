using System;

namespace Faro.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Pais { get; set; }
        public int NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumentoId { get; set; }
        public bool Vip { get; set; }

    }
}