using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Domain.BaseFramework
{
    public interface IEventHandler<in T> where T : IEvent
    {
        void Handle(T @event);
    }
}
