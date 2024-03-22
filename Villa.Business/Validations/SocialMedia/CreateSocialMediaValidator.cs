using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.SocialMedia;

namespace Villa.Business.Validations.SocialMedia
{
    public class CreateSocialMediaValidator : AbstractValidator<CreateSocialMediaDto>
    {
        public CreateSocialMediaValidator()
        {
            RuleFor(x => x.Url).NotEmpty().NotNull().MinimumLength(1);
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(1);
        }
    }
}
