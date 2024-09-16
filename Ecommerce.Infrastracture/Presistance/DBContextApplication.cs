using Ecommerce.Domin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastracture.Presistance
{
    public class DBContextApplication: DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between OrderItem and Product
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)           // OrderItem has one Product
                .WithMany(p => p.OrderItems)        // Product has many OrderItems
                .HasForeignKey(oi => oi.ProductId); // Use ProductId as the foreign key
        }
        public DbSet<User> Users {  get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products {  get; set; }
        public DbSet<Image> Images {  get; set; }
        public DbSet<Review> Reviews {  get; set; }
        public DbSet<Order> Orders {  get; set; }
        public DbSet<OrderItem> OrderItems {  get; set; }

    }
}
