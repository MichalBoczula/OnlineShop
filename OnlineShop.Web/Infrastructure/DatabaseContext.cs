using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Infrastructure.Helper.DBSeed;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace OnlineShop.Web.Infrastructure
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<ShoppingCartMobilePhone> ShoppingCartMobilePhones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderMobilePhone> OrderMobilePhones { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DatabaseContext()
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
            builder.Entity<ShoppingCart>()
                .HasMany(sc => sc.Items)
                .WithOne(i => i.ShoppingCartRef)
                .HasForeignKey(i => i.ShoppingCartId);
            builder.Entity<ShoppingCartMobilePhone>()
                .HasKey(k => new { k.ShoppingCartId, k.MobilePhoneId });
            builder.Entity<ApplicationUser>()
                .HasOne(u => u.ShoppingCart)
                .WithOne(sc => sc.ApplicationUser)
                .HasForeignKey<ApplicationUser>(u => u.ShoppingCardId);
            builder.Entity<MobilePhone>()
                .Property(m => m.MultimediaId).IsRequired(false);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.ShippingAddresses)
                .WithOne(sa => sa.ApplicationUserRef)
                .HasForeignKey(sa => sa.ApplicationUserId);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.ApplicationUserRef)
                .HasForeignKey(o => o.ApplicationUserId);
            builder.Entity<Order>()
                .HasOne(o => o.ShippingAddressRef)
                .WithOne(o => o.OrderRef)
                .HasForeignKey<Order>(o => o.ShippingAddressId);
            builder.Entity<OrderMobilePhone>()
                .HasKey(k => new { k.OrderId, k.MobilePhoneId });

            builder.InitializeSeedInDb();
        }
    }
}
