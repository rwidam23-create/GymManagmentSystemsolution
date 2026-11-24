using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("Varchar").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("Varchar").HasMaxLength(11);
            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x=>x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(t => {
                t.HasCheckConstraint("GymUser_EmailCheck", "Email Like'_%@_%._%'");
                t.HasCheckConstraint("GymUser_PhoneCheck", "LEN(Phone) = 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");
            }
            );

            
        }
    }
}
