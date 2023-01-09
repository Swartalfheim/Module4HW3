using M4HW3.Configurats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.TitleId).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
        }
    }
}
