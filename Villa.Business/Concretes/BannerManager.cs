using MongoDB.Bson;
using System.Linq.Expressions;
using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        public BannerManager(IGenericDal<Banner> genericDal) : base(genericDal)
        {
        }

    }

}
