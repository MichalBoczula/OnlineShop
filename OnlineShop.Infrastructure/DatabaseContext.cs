using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Model;
using OnlineShop.Infrastructure.Helper.DBSeed;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace OnlineShop.Infrastructure
{
    public class DatabaseContext : IdentityDbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems{ get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var prop in builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                prop.SetColumnType("decimal(3,2)");
            }

            builder.Entity<MobilePhone>()
                .HasOne(m => m.Camera)
                .WithOne(c => c.MobilePhoneRef)
                .HasForeignKey<Camera>(c => c.MobilePhoneId);
            builder.Entity<MobilePhone>()
                .HasOne(m => m.Hardware)
                .WithOne(h => h.MobilePhoneRef)
                .HasForeignKey<Hardware>(h => h.MobilePhoneId);
            builder.Entity<MobilePhone>()
                .HasOne(m => m.Screen)
                .WithOne(s => s.MobilePhoneRef)
                .HasForeignKey<Screen>(s => s.MobilePhoneId);
            builder.Entity<MobilePhone>()
                .HasOne(m => m.Multimedia)
                .WithMany(f => f.MobilePhones)
                .HasForeignKey(m => m.MultimediaId);
            //builder.Entity<MobilePhone>()
            //    .Property(m => m.MultimediaId).IsRequired(false);


            builder.InitializeSeedInDb();
        }
    }
}
