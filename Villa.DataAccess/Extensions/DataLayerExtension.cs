using Microsoft.Extensions.DependencyInjection;
using Villa.DataAccess.Abstracts;
using Villa.DataAccess.EntityFramework;
using Villa.DataAccess.Repositories;

namespace Villa.DataAccess.Extensions
{
    public  static class DataLayerExtension
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services)
        {

            services.AddScoped<IBannerDal, EfBannerDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<ICounterDal, EfCounterDal>();
            services.AddScoped<IDealDal, EfDealDal>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IMessageDal, EfMessageDal>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<IVideoDal, EfVideoDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));

            return services;

        }
    }
}
