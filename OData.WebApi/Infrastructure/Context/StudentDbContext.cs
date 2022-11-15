using Microsoft.EntityFrameworkCore;
using OData.WebApi.Infrastructure.DbEntities;
using System.Diagnostics;

namespace OData.WebApi.Infrastructure.Context;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>()
            .HasMany<Student>(g => g.Students)
            .WithOne(s => s.Grade)
            .HasForeignKey(s => s.CurrentGradeId);
    }
}
