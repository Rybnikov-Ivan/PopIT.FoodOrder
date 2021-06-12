using Microsoft.EntityFrameworkCore;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Students;
using popIT.FoodOrder.Infrastructure.Data.Configurations;

namespace popIT.FoodOrder.Infrastructure.Data
{
	public class FoodOrderDbContext : DbContext
	{
		public FoodOrderDbContext(DbContextOptions<FoodOrderDbContext> options) : base(options) {}

		public DbSet<Meat> Meats { get; set; }
		public DbSet<Soup> Soups { get; set; }
		public DbSet<Garnish> Garnishes { get; set; }
		public DbSet<Beverage> Beverages { get; set; }
		
		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BeverageEntityTypeConfiguration).Assembly);
		}
	}
}
