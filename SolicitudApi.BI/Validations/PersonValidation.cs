using FluentValidation;
using SolicitudApi.BI.Dto;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Validations
{
    public class PersonValidation : AbstractValidator<PersonDto>
    {
        public PersonValidation()
        {
			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage("Person's Name is required");
			RuleFor(x => x.LastName)
				.NotEmpty()
				.WithMessage("Person's LastName is required");
			RuleFor(x => x.Gender)
				.NotNull()
				.WithMessage("Person's Gender is required");
			RuleFor(x => x.Direction)
				.NotEmpty()
				.WithMessage("Person's Direction is required");
			RuleFor(x => x.Passport)
				.NotEmpty()
				.WithMessage("Person's Password is required");
		}
    }
}
