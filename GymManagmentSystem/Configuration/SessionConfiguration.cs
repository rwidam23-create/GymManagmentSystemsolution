using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(t=>t.Trainer).WithMany(s=>s.Sessions).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("SessionCapacityConstrain", "Capacity between 1 and 25 ");
                t.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate>StartDate ");
            });
        }
    }
}
