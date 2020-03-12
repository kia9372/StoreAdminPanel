using AdminPanelGetWay.Domain.Aggregates.RoleAggregate.ValueObjects;
using AdminPanelGetWay.Domain.BaseFramework;

namespace AdminPanelGetWay.Domain.Aggregates.RoleAggregate
{
    public class AccessLevel : Entity
    {
        public long RoleId { get; private set; }
        public Access Access { get; private set; }
        public virtual Role Role { get; private set; }

        public AccessLevel()
        {

        }

        private AccessLevel(string controller, string action, long roleId)
        {
            Access = new Access().SetRoleAccess(controller, action);
            RoleId = roleId;
        }


        public AccessLevel AddAccessLevel(string controller, string action, long roleId)
        {
            return new AccessLevel(controller, action, roleId);
        }

    }
}
