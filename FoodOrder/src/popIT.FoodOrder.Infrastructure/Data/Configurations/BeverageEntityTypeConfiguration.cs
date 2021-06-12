using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using popIT.FoodOrder.Core.Beverages;

namespace popIT.FoodOrder.Infrastructure.Data.Configurations
{
	public class BeverageEntityTypeConfiguration : IEntityTypeConfiguration<Beverage>
	{
		public void Configure(EntityTypeBuilder<Beverage> builder)
		{
			builder.ToTable("Beverages");
			builder.HasKey(b => b.Id);

			builder.Property(b => b.Name)
				.IsRequired();
		}
	}
}
