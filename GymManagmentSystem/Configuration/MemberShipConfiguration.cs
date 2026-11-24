using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(m=>m.Plan).WithMany(p=>p.MemberShips).HasForeignKey(p=>p.PlanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
