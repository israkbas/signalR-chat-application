using System;
using Microsoft.EntityFrameworkCore;

namespace chatUyg.Models
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=chatUygDb;Username=postgres;Password=safoz098");

        public DatabaseContext(DbContextOptions <DatabaseContext> options): base(options)
        { }

        public DbSet<Message> Messages { get; set; }
    }
}