using AdminPanelGetWay.Domain.Aggregates.RoleAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminPanelGetWay.Domain.Aggregates.RoleAggregate.Configurations
{
    public class AccessLevelConfiguration : IEntityTypeConfiguration<AccessLevel>
    {
        public void Configure(EntityTypeBuilder<AccessLevel> builder)
        {
            builder.HasOne(x => x.Role).WithMany(x => x.AccessLevels).HasForeignKey(x => x.RoleId);
            builder.OwnsOne<Access>(x => x.Access);
        }
    }
}
