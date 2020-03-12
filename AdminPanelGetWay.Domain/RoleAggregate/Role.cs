using AdminPanelGetWay.Domain.Aggregates.ValueObjects;
using AdminPanelGetWay.Domain.BaseFramework;
using System.Collections.Generic;

namespace AdminPanelGetWay.Domain.Aggregates.RoleAggregate
{
    public class Role : AggregrateRoot
    {
        public RoleName RoleName { get; private set; }
        public ICollection<AccessLevel> AccessLevels { get; private set; }

        public void AddRole(string roleNameFa, string roleNameEn)
        {
            RoleName = new RoleName(roleNameFa, roleNameEn);
        }

        public AccessLevel SetAccessLevel(string controller, string action, long roleId)
        {
            var access = new AccessLevel();
            return access.AddAccessLevel(controller, action, roleId);
        }

    }
}
