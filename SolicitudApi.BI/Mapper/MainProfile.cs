using AutoMapper;
using SolicitudApi.BI.Dto;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Mapper
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Document, DocumentDto>();
            CreateMap<DocumentDto, Document>();

            CreateMap<Person, PersonDto>()
                .ForMember(dto => dto.PhotoFileName, config => config.MapFrom(entity => entity.Photo.FileName));
            CreateMap<PersonDto, Person>();

            CreateMap<Solicitude, SolicitudeDto>();
            CreateMap<SolicitudeDto, Solicitude>();

            CreateMap<Team, TeamDto>();
            CreateMap<TeamDto, Team>();
        }
    }
}
