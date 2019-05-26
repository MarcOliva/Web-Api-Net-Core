using System;

namespace Faro.Domain
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumentoId { get; set; }
        public bool Eliminado { get; set; }

    }
}