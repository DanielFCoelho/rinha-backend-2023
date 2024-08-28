using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Pessoas.Domain;
using System.Linq;

namespace rinha_backend_2023.Capabilities.Persistence
{
    public class RinhaDBContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public RinhaDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=rinha-2023;Username=rinha;Password=eu1234", k => k.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Pessoa>().ToTable(nameof(Pessoa));
            //modelBuilder.Entity<Pessoa>().HasKey(k => k.Id);

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Pessoa>().HasData(new Pessoa
            //{
            //    Id = Guid.NewGuid(),
            //    Apelido = "teste",
            //    Nascimento = new DateOnly(),
            //    Nome = "teste teste",
            //    Stack = null
            //});


        }
    }
}
