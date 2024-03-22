using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Contact;



namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIContact : ViewComponent
    {
        private readonly IContactService _service;
        private readonly IMapper _mapper;

        public _UIContact(IContactService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

       
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var id = ObjectId.Parse("65f1db07a964fce87e45439a");
            var values = await _service.TGetByIdAsync(id);
            var result = _mapper.Map<ResultContactDto>(values);
            return View(result);

            
        }
    }
}
