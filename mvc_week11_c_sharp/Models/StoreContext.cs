using Microsoft.EntityFrameworkCore;

namespace mvc_week11_c_sharp.Models
{
    public class StoreContex: DbContext

    {
        public StoreContex(DbContextOptions<StoreContex> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
