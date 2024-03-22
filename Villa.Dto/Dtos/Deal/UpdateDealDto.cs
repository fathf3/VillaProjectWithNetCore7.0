using MongoDB.Bson;

namespace Villa.Dto.Dtos.Deal
{
    public class UpdateDealDto
    {
        public ObjectId Id { get; set; }
        public string HouseType { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Square { get; set; }
        public string Floor { get; set; }
        public int RoomCount { get; set; }
        public bool HasParkingArea { get; set; }
        public string PaymentType { get; set; }
    }
}
