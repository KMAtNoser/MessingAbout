using KevinEntities.Data;
using Microsoft.EntityFrameworkCore;

namespace KevinEntities;

public class KevinTestDBContext : DbContext
{
    public DbSet<Book> Book => Set<Book>();

    public DbSet<Publisher> Publisher => Set<Publisher>();

    public DbSet<WeatherForecast> WeatherForecast => Set<WeatherForecast>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        _ = optionsBuilder.UseMySQL("server=localhost;database=kevintestdb;user=kevin;password=admin");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        _ = modelBuilder.Entity<Publisher>(entity =>
        {
            _ = entity.HasKey(e => e.ID);
            _ = entity.Property(e => e.Name).IsRequired();
        });

        _ = modelBuilder.Entity<Book>(entity =>
        {
            _ = entity.HasKey(e => e.ISBN);
            _ = entity.Property(e => e.Title).IsRequired();
            _ = entity.HasOne(d => d.Publisher)
                .WithMany(p => p.Books);
        });
    }
}

