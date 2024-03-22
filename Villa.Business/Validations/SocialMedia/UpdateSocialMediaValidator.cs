using FluentValidation;
using Villa.Dto.Dtos.SocialMedia;

namespace Villa.Business.Validations.SocialMedia
{
    public class UpdateSocialMediaValidator : AbstractValidator<UpdateSocialMediaDto>
    {
        public UpdateSocialMediaValidator()
        {
            RuleFor(x => x.Url).NotEmpty().NotNull().MinimumLength(1);
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(1);
        }
    }
}
