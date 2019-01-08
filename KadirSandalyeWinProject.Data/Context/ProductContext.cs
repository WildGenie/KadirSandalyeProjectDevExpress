using KadirSandalyeWinProject.Data.ProductMigration;
using KadirSandalyeWinProject.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KadirSandalyeWinProject.Data.Context
{
    public class ProductContext : BaseDbContext<ProductContext, Configration>
    {
        public ProductContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public ProductContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Category> Category { get; set; }        
        public DbSet<Product> Product { get; set; }
    }
}