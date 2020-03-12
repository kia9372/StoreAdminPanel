using AdminPanelGetWay.Framework.BaseFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Shared.BaseFramework
{
    public class AggregrateRoot : Entity
    {
        private readonly List<IEvent> events = new List<IEvent>();

        protected void Emit(IEvent @event)
        {
            events.Add(@event);
        }

        protected void ClearEvent(IEvent @event)
        {
            events.Clear();
        }
    }
}
