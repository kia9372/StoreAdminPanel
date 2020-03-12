using AdminPanelGetWay.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelGetWay.CommandHandler
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandlerAsync(TCommand command);
    }
}
