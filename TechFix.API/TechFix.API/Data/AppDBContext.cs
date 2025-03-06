using Microsoft.EntityFrameworkCore;
using TechFix.API.Model;

namespace TechFix.API.Data
{

    public class AppDBContext:DbContext
    {
        public AppDBContext()
        { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//create table
        {
            modelBuilder.Entity<Product>().Property(P => P.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Sale>().Property(P => P.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Sale>().Property(A => A.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Sale>().Property(T => T.TotalAmount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<User>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "Server=Lenovo\\SQLEXPRESS;Database=TechFix_Database;Integrated Security=True;TrustServerCertificate=Yes";
            optionsBuilder.UseSqlServer(conn);
        }

    }
}
