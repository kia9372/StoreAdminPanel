using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using AdminPanelGetWay.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Command.Commands
{
    public class AccessLevelCommand : ICommand
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public long RoleId { get; set; }

        public AccessLevelCommand(List<AccessLevelDto> accesses)
        {
            this.Action = Action;
            this.Controller = Controller;
            this.RoleId = RoleId;
        }
    }
}
