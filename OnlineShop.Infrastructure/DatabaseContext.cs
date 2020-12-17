using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OnlineShop.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }

        public DatabaseContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
    }
}
