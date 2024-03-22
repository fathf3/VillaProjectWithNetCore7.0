using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Video;

namespace Villa.Business.Validations.Video
{
    public class CreateVideoValidator : AbstractValidator<CreateVideoDto>
    {
        public CreateVideoValidator()
        {
            RuleFor(x => x.VideoUrl)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
        }
    }
    public class UpdateVideoValidator : AbstractValidator<UpdateVideoDto>
    {
        public UpdateVideoValidator()
        {
            RuleFor(x => x.VideoUrl)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
        }
    }
}
