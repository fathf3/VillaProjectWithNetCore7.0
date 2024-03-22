namespace Villa.Dto.Dtos.Message
{
    public class CreateMessageDto
    {
        public CreateMessageDto()
        {
            MessageDate = DateTime.Now;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
