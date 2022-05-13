using Microsoft.EntityFrameworkCore;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Contexto
{
    public partial class ProyectoSoftwareLibreriaContext : DbContext
    {
        public ProyectoSoftwareLibreriaContext()
        {
        }

        public ProyectoSoftwareLibreriaContext(DbContextOptions<ProyectoSoftwareLibreriaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=ProyectoSoftwareLibreria;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<Alquileres> Alquileres { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<EstadoDeAlquileres> EstadoDeAlquileres { get; set; }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
