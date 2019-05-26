using Faro.Domain;
using Microsoft.EntityFrameworkCore;

namespace Faro.Repository
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<EstadoHabitacion> EstadoHabitaciones { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }

        public DbSet<MetodoPago> MetodoPagos { get; set; }

        public DbSet<Moneda> Monedas { get; set; }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<ReservaCliente> ReservaClientes { get; set; }

        public DbSet<ReservaHabitacion> ReservaHabitaciones { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<TipoHabitacion> TipoHabitaciones { get; set; }
        public DbSet<TipoReserva> TipoReservas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options){
            
        }
        




    }
}