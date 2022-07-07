using Microsoft.EntityFrameworkCore;

namespace InventoryMVC.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options){
            
        }
    }
}