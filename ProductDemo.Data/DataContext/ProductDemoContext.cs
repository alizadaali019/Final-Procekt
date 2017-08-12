using ProductDemo.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ProductDemo.Data.DataContext
{
    public class ProductDemoContext : DbContext
    {
        public DbSet<Category> Category {get; set;}
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductFeature> ProductFeature { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public ProductDemoContext()
            : base("ProductDemoContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
