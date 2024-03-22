using MongoDB.Bson;

namespace Villa.Dto.Dtos.Contact
{
    public class UpdateContactDto
    {
        public ObjectId Id { get; set; }
        public string MapUrl { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
    }
}
