using MongoDB.Bson;

namespace Villa.Dto.Dtos.Counter
{
    public class UpdateCounterDto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
    }
}
