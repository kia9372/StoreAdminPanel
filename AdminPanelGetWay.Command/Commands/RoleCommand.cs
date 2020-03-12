using AdminPanelGetWay.Domain.Aggregates.ValueObjects;

namespace AdminPanelGetWay.Command.Commands
{
    public class RoleCommand : ICommand
    {
        public RoleName RoleName { get; set; }
        public RoleCommand(RoleName roleName)
        {
            RoleName = roleName;
        }
    }
}
