using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AppDbContext : DbContext
{
    

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Etudiant> Etudiants { get; set; }
    public DbSet<Professeur> Professeurs { get; set; }

    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(c => c.Etudiants)
                .WithOne(e => e.Class)
                .HasForeignKey(e => e.ClassId)
                .OnDelete(DeleteBehavior.Cascade);
    
            // modelBuilder.Entity<Professeur>()
            //     .HasMany(p => p.class)
            //     .WithOne(c => c.Professeur)
            //     .HasForeignKey(p => p.ClassId)
            //     .OnDelete(DeleteBehavior.Cascade);
        }
}