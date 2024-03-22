using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Message;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _messageService.TGetListAsync();
            var messageList = _mapper.Map<List<ResultMessageDto>>(values);

            return View(messageList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _messageService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMessageDto createMessageDto)
        {
            if (ModelState.IsValid)
            {
                var newMessage = _mapper.Map<Message>(createMessageDto);
                await _messageService.TCreateAsync(newMessage);
                return RedirectToAction("Index");
            }
            return View(createMessageDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _messageService.TGetByIdAsync(id);
            var updateMessage = _mapper.Map<UpdateMessageDto>(value);
            return View(updateMessage);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateMessageDto updateMessageDto)
        {
            if (ModelState.IsValid)
            {
                var message = _mapper.Map<Message>(updateMessageDto);
                await _messageService.TUpdateAsync(message);
                return RedirectToAction("Index");
            }
            return View(updateMessageDto);
        }

    }
}
