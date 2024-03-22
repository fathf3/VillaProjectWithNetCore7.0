using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Deal;

namespace Villa.Business.Validations.Deal
{
    public class CreateDealValidator : AbstractValidator<CreateDealDto>
    {
        public CreateDealValidator()
        {
            RuleFor(x => x.Floor)
              .NotEmpty()
              .NotNull()
              .MinimumLength(1)
              .WithName("Kat");
            RuleFor(x => x.RoomCount)
               .NotEmpty()
               .NotNull()
               .ExclusiveBetween(1, 25)
               .WithName("Oda Sayısı");


            RuleFor(x => x.PaymentType)
               .NotEmpty()
               .NotNull()
               .MinimumLength(1)
               .WithName("Ödeme Tipi");
            RuleFor(x => x.Square)
               .NotEmpty()
               .NotNull()
               .MinimumLength(3)
               .WithName("Alan");
            RuleFor(x => x.HouseType)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithName("Ev Tipi");

            RuleFor(x => x.ImageUrl)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .WithName("Resim Linki");
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .WithName("Başlık");
            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .WithName("Açıklama");
        }
    }
}
