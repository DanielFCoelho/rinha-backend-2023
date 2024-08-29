using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Pessoas.Domain;

namespace rinha_backend_2023.Capabilities.Persistence;

public class RinhaDBContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public RinhaDBContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pessoa>().Property(k => k.stack)
            .HasConversion(v => string.Join(',', v), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
    }
}
