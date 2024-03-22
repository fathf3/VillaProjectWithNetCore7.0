using MongoDB.Bson;

namespace Villa.Dto.Dtos.Question
{
    public class UpdateQuestionDto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
    }
}
