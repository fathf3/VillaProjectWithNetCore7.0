using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Video;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIVideo : ViewComponent
    {
        private readonly IVideoService _service;
        private readonly IMapper _mapper;

        public _UIVideo(IVideoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = ObjectId.Parse("65fc7f8db65cc065b2105b11");
            var values = await _service.TGetByIdAsync(id);
            var result = _mapper.Map<ResultVideoDto>(values);
            return View(result);
        }
    }
}
