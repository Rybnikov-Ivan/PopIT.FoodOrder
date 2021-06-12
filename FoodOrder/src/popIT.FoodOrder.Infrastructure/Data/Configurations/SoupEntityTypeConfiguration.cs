using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using popIT.FoodOrder.Core.Soups;

namespace popIT.FoodOrder.Infrastructure.Data.Configurations
{
	public class SoupEntityTypeConfiguration : IEntityTypeConfiguration<Soup>
	{
		public void Configure(EntityTypeBuilder<Soup> builder)
		{
			builder.ToTable("Soups");
			builder.HasKey(s => s.Id);

			builder.Property(s => s.Name)
				.IsRequired();
		}
	}
}
