using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Banner;

namespace Villa.Business.Validations.Banner
{
    public class CreateBannerValidator : AbstractValidator<CreateBannerDto>
    {
        public CreateBannerValidator()
        {
            RuleFor(x => x.Title).NotEmpty()
               .NotNull()
               .MinimumLength(3)
               .MaximumLength(150)
               .WithName("Başlık");
            RuleFor(x => x.City)
                .NotNull()
                .MinimumLength(2)
                .WithName("Şehir");

        }
    }
}
