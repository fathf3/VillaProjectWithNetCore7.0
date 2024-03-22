using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Question;

namespace Villa.WebUI.ViewComponents.UILayout
{ 
    public class _UIFAQ : ViewComponent
    {
        private readonly IQuestionService _service;
        private readonly IMapper _mapper;

        public _UIFAQ(IQuestionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.TGetListAsync();
            var results = _mapper.Map<List<ResultQuestionDto>>(values);
            return View(results);
        }

    }
}
