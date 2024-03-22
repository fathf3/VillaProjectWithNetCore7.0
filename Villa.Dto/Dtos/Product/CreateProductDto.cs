namespace Villa.Dto.Dtos.Product
{
    public class CreateProductDto
    {
       
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int BedRoomCount { get; set; }
        public int BathRoomCount { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int ParkingCount { get; set; }
    }
}
