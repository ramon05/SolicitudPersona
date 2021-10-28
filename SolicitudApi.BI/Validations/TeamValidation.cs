using FluentValidation;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Validations
{
    public class TeamValidation : AbstractValidator<Team>
    {
        public TeamValidation()
        {

            RuleFor(x => x.PersonId)
               .NotEmpty()
               .WithMessage("Team's PersonId is required");
            
            RuleFor(x => x.CreadDate)
               .NotEmpty()
               .WithMessage("Team's CreadDate is required");
            
            RuleFor(x => x.Status)
               .NotEmpty()
               .WithMessage("Team's StatusName is required");

        }
    }
}
