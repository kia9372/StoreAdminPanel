using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Shared.BaseFramework
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }
}
