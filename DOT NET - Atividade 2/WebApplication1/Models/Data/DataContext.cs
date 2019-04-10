using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().Property(c => c.Id).HasColumnName("ContactId");
            modelBuilder.Entity<Contato>().HasKey(c => c.Id);
            modelBuilder.Entity<Contato>().Property(c => c.Name).HasMaxLength(30);
            modelBuilder.Entity<Contato>().Property(c => c.Phone).HasMaxLength(14);

            base.OnModelCreating(modelBuilder);
        }
    }
}

