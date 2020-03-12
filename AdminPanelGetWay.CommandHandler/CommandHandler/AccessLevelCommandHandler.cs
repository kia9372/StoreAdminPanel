using AdminPanelGetWay.Command.Commands;
using AdminPanelGetWay.Domain.Aggregates.RoleAggregate;
using AdminPanelGetWay.Domain.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelGetWay.CommandHandler.CommandHandler
{
    public class AccessLevelCommandHandler : ICommandHandler<AccessLevelCommand>
    {
        private readonly IDomainUnitOfWork unitOfWork;

        public AccessLevelCommandHandler(IDomainUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task HandlerAsync(AccessLevelCommand command)
        {
            try
            {
                var role = new Role();
                var access = role.SetAccessLevel(command.Controller, command.Action, command.RoleId);
                unitOfWork.RoleRepository.AddAccessLevel(access);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
