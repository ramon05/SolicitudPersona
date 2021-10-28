using Microsoft.AspNetCore.Mvc;
using SolicitudApi.BI.Dto;
using SolicitudApi.Model.Entities;
using SolicitudApi.Services.Services;

namespace SolicitudApi.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
    public class TeamController : BaseController<Team, TeamDto>
    {
        public TeamController(ITeamService service) : base(service)
        {
        }
    }
}
