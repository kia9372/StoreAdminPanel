

using AdminPanelGetWay.Command;
using AdminPanelGetWay.CommandHandler;
using AdminPanelGetWay.CommandHandler.Dispatchers;
using System;
using System.Threading.Tasks;

namespace AdminPanelGetWay.Common.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider context;

        public CommandDispatcher(IServiceProvider context)
        {
            this.context = context;
        }

        public async Task SendAsync<T>(T command) where T : ICommand
        {
            var service = context.GetService(typeof(ICommandHandler<T>)) as ICommandHandler<T>;
            await service.HandlerAsync(command);
        }
    }
}
