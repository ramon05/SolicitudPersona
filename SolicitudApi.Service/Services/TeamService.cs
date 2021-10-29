using AutoMapper;
using FluentValidation;
using SolicitudApi.BI.Dto;
using SolicitudApi.Model.Entities;
using SolicitudApi.Model.Repositories;
using SolicitudApi.Service.Services;
using SolicitudApi.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Services.Services
{
    public interface ITeamService : IBaseService<Team, TeamDto> { }
    public class TeamService : BaseService<Team, TeamDto>, ITeamService
    {
        public TeamService(
            ITeamRepository repository,
            IMapper mapper,
            IValidator<TeamDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
