using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class DealManager : GenericManager<Deal>, IDealService
    {
        public DealManager(IGenericDal<Deal> genericDal) : base(genericDal)
        {
        }

    }
}
