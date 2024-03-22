using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class CounterManager : GenericManager<Counter>, ICounterService
    {
        public CounterManager(IGenericDal<Counter> genericDal) : base(genericDal)
        {
        }

    }

}
