using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using popIT.FoodOrder.Core.Students;

namespace popIT.FoodOrder.Infrastructure.Data.Configurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(s => s.StudentTicket);

            builder.Property(s => s.Name)
                .IsRequired();
            
            builder.Property(s => s.StudentTicket)
                .IsRequired();
        }
    }
}