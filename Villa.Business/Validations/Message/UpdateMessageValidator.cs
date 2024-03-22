using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Message;

namespace Villa.Business.Validations.Message
{
    public class UpdateMessageValidator : AbstractValidator<UpdateMessageDto>
    {
        public UpdateMessageValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull()
               .MinimumLength(2)
               .MaximumLength(70);

            RuleFor(x => x.Email)
                .NotNull()
                .MinimumLength(2)
                .EmailAddress();

            RuleFor(x => x.Subject)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(150);
            RuleFor(x => x.MessageContent)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(500)
                .WithMessage("Mesaj maksimum 500 karakter olabilir");
        }
    }
}
