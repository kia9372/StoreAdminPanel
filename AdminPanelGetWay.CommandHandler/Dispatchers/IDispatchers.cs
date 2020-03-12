using AdminPanelGetWay.Command;
using System.Threading.Tasks;

namespace AdminPanelGetWay.Common.Dispatchers
{
    public interface IDispatchers
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
