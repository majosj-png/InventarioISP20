using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Backend.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext()
        {

        }

        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes
        {
            get; set;
        }
        public DbSet<Localidad> Localidades
        {
            get; set;
        }
        public DbSet<Provincia> Provincias 
        { 
            get; set;
        }

        public DbSet<Pais> Paises
        {
            get; set;
        }

        //creamos el método OnConfiguring para configurar la cadena de conexión a la base de datos postgreSQL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configurar la cadena de conexión a la base de datos PostgreSQL
                //optionsBuilder.UseNpgsql();
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();

                //string cadenaConexion = configuration.GetConnectionString("mysqlRemote");
                var cadenaConexion = configuration.GetConnectionString("postgresRemote");

                optionsBuilder.UseNpgsql(cadenaConexion);
            }
        }

        //creamos el metodo OnModelCreating para insertar datos semillas en tabla Clietes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Firstname = "Juan", Lastname = "Pérez", Dni = "12345678", Address = "Calle Falsa 123", LocalidadId = 1, ProvinciaId = 1 },
                new Cliente { Id = 2, Firstname = "María", Lastname = "González", Dni = "87654321", Address = "Avenida Siempre Viva 456", LocalidadId = 2, ProvinciaId = 3 },
                new Cliente { Id = 3, Firstname = "Pedro", Lastname = "López", Dni = "11223344", Address = "Callejón del Beso 789", LocalidadId = 3, ProvinciaId = 2 }
            );

            //cargamos datos semilla para la tabla Localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Name = "Buenos Aires", ProvinciaId = 1 },
                new Localidad { Id = 2, Name = "Córdoba", ProvinciaId = 2 },
                new Localidad { Id = 3, Name = "Santa Fe", ProvinciaId = 3 },
                new Localidad { Id = 4, Name = "San Justo", ProvinciaId = 3 }
            );
            //cargamos datos semilla para la tabla Provincias
            modelBuilder.Entity<Provincia>().HasData(
                new Provincia { Id = 1, Name = "Buenos Aires", PaisId = 1 },
                new Provincia { Id = 2, Name = "Córdoba", PaisId = 1 },
                new Provincia { Id = 3, Name = "Santa Fe", PaisId = 1 }
            );

            //desactivamos la eliminación en cascada para la relación entre Localidad y Provincia usando Fluent API
            modelBuilder.Entity<Localidad>()
                .HasOne(l => l.Provincia)
                .WithMany()
                .HasForeignKey(l => l.ProvinciaId)
                .OnDelete(DeleteBehavior.Restrict);
            

            //cargamos datos semilla para la tabla Paises
            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Name = "Argentina" },
                new Pais { Id = 2, Name = "Brasil" },
                new Pais { Id = 3, Name = "Chile" }
            );


            //configuramos la propiedad Created_at para que tenga ub valor por defecto la fecha y hora actual
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Created_at)
                .HasDefaultValueSql("NOW()");

            //configuramos los queries filters para que no se muestren los clientes eliminados
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Localidad>()
                .HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Provincia>()
                .HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Pais>()
                .HasQueryFilter(p => !p.IsDeleted);
        }


    }
}
