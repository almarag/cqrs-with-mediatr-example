using Microsoft.EntityFrameworkCore;
using StudentsMicroService.Infrastructure.Entities;

namespace StudentsMicroService.Infrastructure.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<PersonalData> PersonalData { get; set; }
        public DbSet<AcademicData> AcademicData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CustomerDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<PersonalData>().ToTable("PersonalData");
            modelBuilder.Entity<AcademicData>().ToTable("AcademicData");
        }

    }
}
