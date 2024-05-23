using web_ventas_ds504.Models;
using Microsoft.EntityFrameworkCore;

namespace web_ventas_ds504.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { 
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Departamento> Departamento { get; set;}


        public DbSet<Autor> Autor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
