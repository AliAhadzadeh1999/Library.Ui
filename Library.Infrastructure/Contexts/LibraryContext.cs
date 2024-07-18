using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Insurance>? Insurance { get; set; }
    public DbSet<InsuranceType>? InsuranceType { get; set; }
    public DbSet<Dr>? Dr { get; set; }
    public DbSet<Labratory>? Labratory { get; set; }
    public DbSet<LabratoryType>? LabratoryType { get; set; }
    public DbSet<Medicine>? Medicine { get; set; }
    public DbSet<MedicineType>? MedicineType { get; set; }
    public DbSet<Person>? Person { get; set; }
    public DbSet<Prescription>? Prescription { get; set; }
    public DbSet<Radiology>? Radiology { get; set; }
    public DbSet<RadiologyType>? RadiologyType { get; set; }
    public DbSet<User>? User { get; set; }
    public DbSet<LoginAccess>? LoginAccess { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString.ConnectionString.AdvConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

}
