using System.Collections.Generic;

namespace AdminPanelGetWay.Domain.BaseFramework
{
    public class AggregrateRoot : Entity
    {
        private readonly List<IEvent> events = new List<IEvent>();
        public virtual IReadOnlyList<IEvent> Events => events;

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
