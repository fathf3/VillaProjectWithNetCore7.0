using FluentValidation;
using Villa.Dto.Dtos.Product;

namespace Villa.Business.Validations.Product
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ImageUrl)
              .NotEmpty().WithMessage("Lutfen urun gorseli ekleyiniz..!")
              .NotNull().WithMessage("Lutfen urun gorseli ekleyiniz..!");

            RuleFor(x => x.Category)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(150);

            RuleFor(x => x.BedRoomCount)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz");

            RuleFor(x => x.BathRoomCount)
            .NotNull()
            .NotEmpty()
            .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz");

            RuleFor(x => x.Area)
           .NotNull()
           .NotEmpty()
           .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz");

            RuleFor(x => x.Floor)
           .NotNull()
           .NotEmpty()
           .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz");

            RuleFor(x => x.ParkingCount)
          .NotNull()
          .NotEmpty()
          .GreaterThanOrEqualTo(0).WithMessage("Lutfen Sadece sayı giriniz");



        }
    }
}
