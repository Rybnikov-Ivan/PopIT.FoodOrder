using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using popIT.FoodOrder.Core.Meats;

namespace popIT.FoodOrder.Infrastructure.Data.Configurations
{
	public class MeatEntityTypeConfiguration : IEntityTypeConfiguration<Meat>
	{
		public void Configure(EntityTypeBuilder<Meat> builder)
		{
			builder.ToTable("Meats");
			builder.HasKey(m => m.Id);
		}
	}
}
