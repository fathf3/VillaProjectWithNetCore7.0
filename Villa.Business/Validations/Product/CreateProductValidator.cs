using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.Dtos.Product;

namespace Villa.Business.Validations.Product
{
    public class CreateProductValidator : AbstractValidator<CreateProductDto>
    {
        //public string ImageUrl { get; set; }
        //public string Category { get; set; }
        //public string Title { get; set; }
        //public int BedRoomCount { get; set; }
        //public int BathRoomCount { get; set; }
        //public int Area { get; set; }
        //public int Floor { get; set; }
        //public int ParkingCount { get; set; }

        public CreateProductValidator()
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
               .NotNull().WithName("Oda Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .NotEmpty().WithName("Oda Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .GreaterThanOrEqualTo(1).WithName("Oda Sayısı").WithMessage("Lutfen Sadece sayı giriniz");
           

            RuleFor(x => x.BathRoomCount)
            .NotNull().WithName("Banyo Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .NotEmpty().WithName("Banyo Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz")
           .WithName("Banyo sayısı");

            RuleFor(x => x.Area)
           .NotNull().WithName("Alan m2").WithMessage("Lutfen Sadece sayı giriniz")
           .NotEmpty().WithName("Alan m2").WithMessage("Lutfen Sadece sayı giriniz")
           .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz")
           .WithName("Alan m2");
           
            RuleFor(x => x.Floor)
           .NotNull().WithName("Kat Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .NotEmpty().WithName("Kat Sayısı").WithMessage("Lutfen Sadece sayı giriniz")
           .GreaterThanOrEqualTo(1).WithMessage("Lutfen Sadece sayı giriniz")
           .WithName("Kat Sayısı");

            RuleFor(x => x.ParkingCount)
          .NotNull().WithName("Park Alanı").WithMessage("Lutfen Sadece sayı giriniz")
           .NotEmpty().WithName("Park Alanı").WithMessage("Lutfen Sadece sayı giriniz")
           .GreaterThanOrEqualTo(0).WithMessage("Lutfen Sadece sayı giriniz")
           .WithName("Park Alanı");





        }
    }
}
