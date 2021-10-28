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
    public interface IDocumentService : IBaseService<Document, DocumentDto> { }
    public class DocumentService : BaseService<Document, DocumentDto>, IDocumentService
    {
        public DocumentService(
            IDocumentRepository repository,
            IMapper mapper,
            IValidator<DocumentDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
