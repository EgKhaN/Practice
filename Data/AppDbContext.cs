using Alıştırma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alıştırma.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, Title = "Title 1 *Seed", Description = "Description 1" },
                new Ticket { Id = 2, Title = "Title 2 *Seed", Description = "Description 2" },
                new Ticket { Id = 3, Title = "Title 3 *Seed", Description = "Description 3" },
                new Ticket { Id = 4, Title = "Title 4 *Seed", Description = "Description 4" },
                new Ticket { Id = 5, Title = "Title 5 *Seed", Description = "Description 5" }
            );
        }

        
    }
}
