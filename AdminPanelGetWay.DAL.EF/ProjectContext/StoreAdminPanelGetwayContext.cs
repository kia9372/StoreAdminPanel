using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelGetWay.DAL.EF.ProjectContext
{
    public class StoreAdminPanelGetwayContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer(@"Server=.; initial catalog=StoreAdminPanelGetway;integrated security=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Role).Assembly);
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }

    }
}
