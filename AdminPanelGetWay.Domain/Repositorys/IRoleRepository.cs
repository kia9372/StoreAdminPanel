using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Domain.Repositorys
{
    public interface IRoleRepository
    {
        void AddRole(Role role);
        void AddAccessLevel(List<AccessLevel> access);
    }
}
