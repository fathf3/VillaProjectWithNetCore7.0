using Villa.DataAccess.Abstracts;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
    public class EfQuestionDal : GenericRepository<Question>, IQuestionDal
    {
        public EfQuestionDal(VillaContext context) : base(context)
        {
        }
    }
}
