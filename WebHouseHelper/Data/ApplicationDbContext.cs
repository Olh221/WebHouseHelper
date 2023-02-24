using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebHouseHelper.Data
{
    public class ApplicationDbContext : IdentityDbContext<AverageUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyServices> MyServices { get; set; }
        public DbSet<MyOrders> MyOrders { get; set; }
        public DbSet<Driveway> Driveways { get; set; }
        public DbSet<RoofCovering> RoofCoverings { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<WindowsInstalation> WindowsInstalations { get; set; }
        public DbSet<HouseCleaning> HouseCleanings { get; set; }
        public DbSet<Electricity> Electricitys { get; set; }
        public DbSet<InsulationOfTheFacade> InsulationOfTheFacades { get; set; }
        public DbSet<Plumbind> Plumbinds { get; set; }
        public DbSet<Landscaping> Landscapings { get; set; }
        public DbSet<LayingTiles> LayingTiles { get; set; }
        public DbSet<Design> Designs { get; set; }
    }
}