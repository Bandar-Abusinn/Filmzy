using Filmzy.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Filmzy.Models.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }



        public DbSet<Product> product { get; set; }
        public DbSet<details> details { get; set; }
        public DbSet<StoreData> storedata { get; set; }


    }
}
