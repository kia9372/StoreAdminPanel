using AdminPanelGetWay.Framework.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Domain.Repositorys
{
    public interface IDomainUnitOfWork : IUnitOfWork
    {
        public IRoleRepository RoleRepository { get; }
    }
}
