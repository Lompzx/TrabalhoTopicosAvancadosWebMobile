using Microsoft.EntityFrameworkCore;
using Trabalho.Models;

namespace Trabalho.Repository
{
    public class CaseModeMapping : IEntityTypeConfiguration<CaseModeModel>    
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CaseModeModel> builder)
        {
            builder.ToTable("TBL_CASEMODE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(800);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(800);
            builder.Property(x => x.Price).IsRequired();
        }
    }
}