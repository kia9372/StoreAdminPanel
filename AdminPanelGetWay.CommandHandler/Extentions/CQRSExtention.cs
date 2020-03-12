using AdminPanelGetWay.CommandHandler.Dispatchers;
using AdminPanelGetWay.Common.Dispatchers;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace AdminPanelGetWay.CommandHandler.Extentions
{
    public static class CQRSExtention
    {
        public static void AddDispatchers(this ContainerBuilder builder)
        {
            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();
            builder.RegisterType<Dispatcher>().As<IDispatchers>();
        }

        public static void InjectCommandHandlers(this IServiceCollection services)
        {
            var handlers = typeof(IDispatchers).Assembly.GetTypes()
                .Where(t => t.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>))
            );

            foreach (var handler in handlers)
            {
                services.AddScoped(handler.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)), handler);
            }
        }
    }
}
