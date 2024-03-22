using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Question;

namespace Villa.Business.Validations.Question
{
    public class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
    {
        public CreateQuestionValidator()
        {
            RuleFor(x => x.Title)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(150);
            RuleFor(x => x.Answer)
               .NotNull()
               .NotEmpty()
               .MinimumLength(2)
               .MaximumLength(550);
        }
    }
}
