using Microsoft.EntityFrameworkCore;

namespace CRUD_example_1.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }


        public DbSet<ProductModel> Products { get; set; }

    }
}
