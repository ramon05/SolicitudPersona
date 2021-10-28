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
    public interface ISolicitudeService : IBaseService<Solicitude, SolicitudeDto> { }
    public class SolicitudeService : BaseService<Solicitude, SolicitudeDto>, ISolicitudeService
    {
        public SolicitudeService(
            ISolicitudeRepository repository,
            IMapper mapper,
            IValidator<SolicitudeDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
