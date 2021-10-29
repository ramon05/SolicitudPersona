using FluentValidation;
using SolicitudApi.BI.Dto;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Validations
{
    public class SolicitudeValidation : AbstractValidator<SolicitudeDto>
    {
        public SolicitudeValidation()
        {
            RuleFor(x => x.CreadDate)
               .NotEmpty()
               .WithMessage("Solicitude's CreadDate is required");
            
            RuleFor(x => x.StatusName)
               .NotEmpty()
               .WithMessage("Solicitude's StatusName is required");
            RuleFor(x => x.PersonId)
               .NotEmpty()
               .WithMessage("Solicitude's PersonId is required");
        }
    }
}
