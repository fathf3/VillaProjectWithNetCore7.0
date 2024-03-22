using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Counter;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UICounter : ViewComponent
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public _UICounter(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var counterList = await _counterService.TGetListAsync();
            var result = _mapper.Map<List<ResultCounterDto>>(counterList);
            return View(result);
        }
    }
}
