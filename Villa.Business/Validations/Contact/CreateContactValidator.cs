using FluentValidation;
using Villa.Dto.Dtos.Contact;

namespace Villa.Business.Validations.Contact
{
    public class CreateContactValidator : AbstractValidator<CreateContactDto>
    {
        public CreateContactValidator()
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
