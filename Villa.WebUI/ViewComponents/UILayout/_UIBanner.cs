using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Banner;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIBanner : ViewComponent
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public _UIBanner(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var bannerList = await _bannerService.TGetListAsync();
            var result =_mapper.Map<List<ResultBannerDto>>(bannerList);
            return View(result);
        }
    }
}
