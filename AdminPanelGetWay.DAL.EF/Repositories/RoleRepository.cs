using AdminPanelGetWay.DAL.EF.ProjectContext;
using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using AdminPanelGetWay.Domain.Repositorys;
using AdminPanelGetWay.DTO;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.DAL.EF.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly StoreAdminPanelGetwayContext context;

        public RoleRepository(StoreAdminPanelGetwayContext context)
        {
            this.context = context;
        }

        public void AddAccessLevel(List<AccessLevel> access)
        {
            context.BulkInsert(access);
        }

        /// <summary>
        /// Add New Role for Aggregat Role
        /// </summary>
        /// <param name="role"></param>
        public void AddRole(Role role)
        {
            context.Add(role);
        }
    }
}
