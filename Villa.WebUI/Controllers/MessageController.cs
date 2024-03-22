using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Contact;
using Villa.Dto.Dtos.Message;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _service;
        private readonly IMapper _mapper;

        public MessageController(IMessageService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessage)
        {
            var result = _mapper.Map<Message>(createMessage);
            await _service.TCreateAsync(result);
            return RedirectToAction("Index", "Home");
        }
    }
}
