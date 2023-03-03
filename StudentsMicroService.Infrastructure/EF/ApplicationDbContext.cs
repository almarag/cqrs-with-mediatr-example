﻿using Microsoft.EntityFrameworkCore;
using StudentsMicroService.Infrastructure.Entities;

namespace StudentsMicroService.Infrastructure.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<StudentState> StudentStates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CustomerDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentState>().ToTable("StudentStates");
        }
    }
}
