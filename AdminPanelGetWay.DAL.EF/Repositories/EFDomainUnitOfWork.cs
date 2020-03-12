using AdminPanelGetWay.DAL.EF.ProjectContext;
using AdminPanelGetWay.Domain.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.DAL.EF.Repositories
{
    public class EFDomainUnitOfWork : IDomainUnitOfWork
    {
        private readonly StoreAdminPanelGetwayContext context;

        public EFDomainUnitOfWork(StoreAdminPanelGetwayContext context)
        {
            this.context = context;
            RoleRepository = new RoleRepository(context);
        }

        public IRoleRepository RoleRepository { get; private set; }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
