using TraverlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace TraverlServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<Ejemplo> Ejemplos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        

    }
}