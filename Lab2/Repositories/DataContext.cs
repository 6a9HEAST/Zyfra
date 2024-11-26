using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab2.Repositories
{
    public class DataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
