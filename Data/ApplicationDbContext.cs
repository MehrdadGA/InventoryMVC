
using InventoryMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryMVC.Data{
    public class ApplicationDbContext: DbContext{
        // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        // : base(options){
            
        // }

        public ApplicationDbContext(DbContextOptions options) : base(options){}

        public DbSet<CustomerModel> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test123;Integrated Security=True");
        }
    }
}