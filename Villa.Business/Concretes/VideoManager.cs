using Villa.Business.Abstracts;
using Villa.DataAccess.Abstracts;
using Villa.Entity.Entities;

namespace Villa.Business.Concretes
{
    public class VideoManager : GenericManager<Video>, IVideoService
    {
        public VideoManager(IGenericDal<Video> genericDal) : base(genericDal)
        {
        }

    }

}
