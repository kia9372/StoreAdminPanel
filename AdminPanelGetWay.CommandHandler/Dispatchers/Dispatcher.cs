using AdminPanelGetWay.Command;
using AdminPanelGetWay.CommandHandler.Dispatchers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelGetWay.Common.Dispatchers
{
    public class Dispatcher : IDispatchers
    {
        public readonly ICommandDispatcher commandDispatcher;
        public Dispatcher(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        public async Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            await commandDispatcher.SendAsync(command);
        }
    }
}
