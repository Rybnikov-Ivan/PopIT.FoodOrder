using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using popIT.FoodOrder.Core.Garnishes;
using System;
using System.Collections.Generic;
using System.Text;

namespace popIT.FoodOrder.Infrastructure.Data.Configurations
{
	public class GarnishEntityTypeConfiguration : IEntityTypeConfiguration<Garnish>
	{
		public void Configure(EntityTypeBuilder<Garnish> builder)
		{
			builder.ToTable("Garnishes");
			builder.HasKey(g => g.Id);
		}
	}
}
