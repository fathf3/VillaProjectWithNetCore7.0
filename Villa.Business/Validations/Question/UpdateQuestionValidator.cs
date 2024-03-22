using FluentValidation;
using Villa.Dto.Dtos.Question;

namespace Villa.Business.Validations.Question
{
    public class UpdateQuestionValidator : AbstractValidator<UpdateQuestionDto>
    {
        public UpdateQuestionValidator()
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
