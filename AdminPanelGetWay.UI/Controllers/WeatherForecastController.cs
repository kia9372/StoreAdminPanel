using AdminPanelGetWay.Command.Commands;
using AdminPanelGetWay.Common.Dispatchers;
using AdminPanelGetWay.Domain.Aggregates.ValueObjects;
using AdminPanelGetWay.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AdminPanelGetWay.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDispatchers dispatchers;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDispatchers dispatchers)
        {
            _logger = logger;
            this.dispatchers = dispatchers;
        }

        [HttpGet]
        public void Get()
        {
            List<AccessLevelDto> accesses = new List<AccessLevelDto>();
            accesses.Add(new AccessLevelDto
            {
                Action = "AddUser",
                Controller = "User",
                RoleId = 1003
            });
            accesses.Add(new AccessLevelDto
            {
                Action = "AddUser",
                Controller = "User",
                RoleId = 1003
            });
            dispatchers.SendAsync(new AccessLevelCommand(accesses));
        }
    }
}
