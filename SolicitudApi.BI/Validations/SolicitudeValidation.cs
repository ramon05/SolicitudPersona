using FluentValidation;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Validations
{
    public class SolicitudeValidation : AbstractValidator<Solicitude>
    {
        public SolicitudeValidation()
        {
            RuleFor(x => x.CreadDate)
               .NotEmpty()
               .WithMessage("Solicitude's CreadDate is required");
            
            RuleFor(x => x.StatusName)
               .NotEmpty()
               .WithMessage("Solicitude's StatusName is required");

        }
    }
}
