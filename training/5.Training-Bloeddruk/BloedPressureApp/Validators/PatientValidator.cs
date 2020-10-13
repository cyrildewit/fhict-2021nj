using BloedPressureApp.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloedPressureApp.Validators
{
    public class PatientValidator : AbstractValidator<PatientModel>
    {
        public PatientValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Het veld voornaam mag niet leeg zijn.");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Het veld achternaam mag niet leeg zijn.");

            RuleFor(p => p.Birthdate)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Het veld geboortedatum mag niet leeg zijn.");

            RuleFor(p => p.Gender)
                .Cascade(CascadeMode.Stop)
                .IsInEnum()
                .WithMessage("Er is geen geldige geslacht ingevuld.");
        }
    }
}
