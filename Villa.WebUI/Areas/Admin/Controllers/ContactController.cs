using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Contact;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _contactService.TGetListAsync();
            var contactList = _mapper.Map<List<ResultContactDto>>(values);

            return View(contactList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _contactService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateContactDto createContactDto)
        {
            var newContact = _mapper.Map<Contact>(createContactDto);
            await _contactService.TCreateAsync(newContact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _contactService.TGetByIdAsync(id);
            var updateContact = _mapper.Map<UpdateContactDto>(value);
            return View(updateContact);
        }
        [HttpPost]
        
        public async Task<IActionResult> Update(UpdateContactDto updateContactDto)
        {
            if (ModelState.IsValid)
            {
                var contact = _mapper.Map<Contact>(updateContactDto);
                await _contactService.TUpdateAsync(contact);
                return RedirectToAction("Index");
            }

            return View(updateContactDto);
        }

    }
}

