using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Framework.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
