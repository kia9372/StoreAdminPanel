using AdminPanelGetWay.Domain.Aggregates.RoleAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.DTO
{
    public class AccessLevelDto
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public long RoleId { get; set; }
    }
}
