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
    public interface IPersonService : IBaseService<Person, PersonDto> { }
    public class PersonService : BaseService<Person, PersonDto>, IPersonService
    {
        public PersonService(
            IPersonRepository repository,
            IMapper mapper,
            IValidator<PersonDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
