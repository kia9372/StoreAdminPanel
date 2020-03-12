using AdminPanelGetWay.Command.Commands;
using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using AdminPanelGetWay.Domain.Repositorys;
using System;
using System.Threading.Tasks;

namespace AdminPanelGetWay.CommandHandler.CommandHandler
{
    public class RoleCommandHandler : ICommandHandler<RoleCommand>
    {
        private readonly IDomainUnitOfWork unitOfWork;

        public RoleCommandHandler(IDomainUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task HandlerAsync(RoleCommand command)
        {
            try
            {
                var role = new Role();
                role.AddRole(command.RoleName.RoleNameFa, command.RoleName.RoleNameEn);
                unitOfWork.RoleRepository.AddRole(role);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
