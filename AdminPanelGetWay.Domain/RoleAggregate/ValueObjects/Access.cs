

using AdminPanelGetWay.Domain.BaseFramework;
using System.Collections.Generic;

namespace AdminPanelGetWay.Domain.Aggregates.RoleAggregate.ValueObjects
{
    public class Access : ValueObject<Access>
    {
        public string RoleAccess { get; set; }

        public Access()
        {

        }
        private Access(string controller, string action)
        {
            RoleAccess = string.Format("{0}:{1}", controller, action);
        }

        public Access SetRoleAccess(string controller, string action)
        {
            return new Access(controller, action);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return RoleAccess;
        }
    }
}
