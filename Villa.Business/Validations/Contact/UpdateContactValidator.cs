using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Contact;

namespace Villa.Business.Validations.Contact
{
    public class UpdateContactValidator : AbstractValidator<UpdateContactDto>
    {
        public UpdateContactValidator()
        {
            RuleFor(x => x.Phone).NotEmpty()
              .NotNull()
              .MinimumLength(3)
              .MaximumLength(12)
              .WithName("Telefon");

            RuleFor(x => x.MapUrl)
                    .NotNull()
                    .MinimumLength(2)
                    .WithName("Adres Linki");
            RuleFor(x => x.Address)
                    .NotNull()
                    .MinimumLength(2)
                    .WithName("Adres");
            RuleFor(x => x.Email)
                   .NotNull()
                   .EmailAddress()
                   .MinimumLength(2)
                   .WithName("E-Posta");
        }
    }
}
