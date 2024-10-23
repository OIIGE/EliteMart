using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EliteMart.Model;
using System;
using System.Collections.Generic;

namespace EliteMart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}