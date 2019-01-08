using KadirSandalyeWinProject.Data.Context;
using System.Data.Entity.Migrations;

namespace KadirSandalyeWinProject.Data.ProductMigration
{
    public class Configration : DbMigrationsConfiguration<ProductContext>
    {
        public Configration()
        {
            //Migration işlemini otamatik yap.
            AutomaticMigrationsEnabled = true;

           
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
