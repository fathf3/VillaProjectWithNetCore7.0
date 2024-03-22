using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Feature;

namespace Villa.Business.Validations.Feature
{
    public class UpdateFeatureValidator : AbstractValidator<UpdateFeatureDto>
    {
        public UpdateFeatureValidator()
        {
            RuleFor(x => x.ImageUrl)
  .NotEmpty()
  .NotNull();

            RuleFor(x => x.Title)
             .NotEmpty()
             .NotNull()
             .MinimumLength(2);


            RuleFor(x => x.SubTitle)
               .NotEmpty()
               .NotNull()
               .MinimumLength(1);

            RuleFor(x => x.Square)
               .NotEmpty()
               .NotNull();


            RuleFor(x => x.Safety)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Payment)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Contract)
                .NotEmpty()
                .NotNull();
        }
    }
}
