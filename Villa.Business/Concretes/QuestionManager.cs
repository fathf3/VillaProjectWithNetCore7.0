using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class QuestionManager : GenericManager<Question>, IQuestionService
    {
        public QuestionManager(IGenericDal<Question> genericDal) : base(genericDal)
        {
        }

    }

}
