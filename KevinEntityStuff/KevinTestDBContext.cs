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
        optionsBuilder.UseMySQL("server=localhost;database=kevintestdb;user=kevin;password=admin");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.ID);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.ISBN);
            entity.Property(e => e.Title).IsRequired();
            entity.HasOne(d => d.Publisher)
                .WithMany(p => p.Books);
        });
    }
}

