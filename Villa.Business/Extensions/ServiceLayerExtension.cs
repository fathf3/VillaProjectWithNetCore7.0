using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Villa.Business.Abstracts;
using Villa.Business.Concretes;
using Villa.Business.Validations.Banner;
using Villa.Business.Validations.Contact;
using Villa.Business.Validations.Deal;
using Villa.Business.Validations.Feature;
using Villa.Business.Validations.Message;
using Villa.Business.Validations.Product;
using Villa.Business.Validations.Question;
using Villa.Business.Validations.SocialMedia;
using Villa.Business.Validations.Video;
using Villa.Dto.Dtos.Banner;
using Villa.Dto.Dtos.Contact;
using Villa.Dto.Dtos.Deal;
using Villa.Dto.Dtos.Feature;
using Villa.Dto.Dtos.Message;
using Villa.Dto.Dtos.Product;
using Villa.Dto.Dtos.Question;
using Villa.Dto.Dtos.SocialMedia;
using Villa.Dto.Dtos.Video;

namespace Villa.Business.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            // DI
            services.AddScoped<IBannerService, BannerManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<ICounterService, CounterManager>();
            services.AddScoped<IDealService, DealManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IVideoService, VideoManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            // Validate
            services.AddTransient<IValidator<UpdateContactDto>, UpdateContactValidator>();
            services.AddTransient<IValidator<CreateContactDto>, CreateContactValidator>();

            services.AddTransient<IValidator<UpdateBannerDto>, UpdateBannerValidator>();
            services.AddTransient<IValidator<CreateBannerDto>, CreateBannerValidator>();

            services.AddTransient<IValidator<UpdateDealDto>, UpdateDealValidator>();
            services.AddTransient<IValidator<CreateDealDto>, CreateDealValidator>();

            services.AddTransient<IValidator<UpdateFeatureDto>, UpdateFeatureValidator>();
            services.AddTransient<IValidator<CreateFeatureDto>, CreateFeatureValidator>();

            services.AddTransient<IValidator<UpdateMessageDto>, UpdateMessageValidator>();
            services.AddTransient<IValidator<CreateMessageDto>, CreateMessageValidator>();

            services.AddTransient<IValidator<UpdateProductDto>, UpdateProductValidator>();
            services.AddTransient<IValidator<CreateProductDto>, CreateProductValidator>();

            services.AddTransient<IValidator<UpdateQuestionDto>, UpdateQuestionValidator>();
            services.AddTransient<IValidator<CreateQuestionDto>, CreateQuestionValidator>();
           
            services.AddTransient<IValidator<UpdateVideoDto>, UpdateVideoValidator>();
            services.AddTransient<IValidator<CreateVideoDto>, CreateVideoValidator>();

            services.AddTransient<IValidator<UpdateSocialMediaDto>, UpdateSocialMediaValidator>();
            services.AddTransient<IValidator<CreateSocialMediaDto>, CreateSocialMediaValidator>();

            return services;

        }
    }
}
