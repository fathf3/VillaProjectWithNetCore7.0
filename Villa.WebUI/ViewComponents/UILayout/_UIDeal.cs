using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Deal;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIDeal : ViewComponent
    {
        private readonly IDealService _dealService;
        private readonly IMapper _mapper;

        public _UIDeal(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dealList = await _dealService.TGetListAsync();
            var result = _mapper.Map<List<ResultDealDto>>(dealList);
            return View(result);
        }
    }
}
