using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class MessageManager : GenericManager<Message>, IMessageService
    {
        public MessageManager(IGenericDal<Message> genericDal) : base(genericDal)
        {
        }

    }

}
