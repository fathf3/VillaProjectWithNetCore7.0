using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Feature;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIFeatured  : ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        
        public _UIFeatured(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var id = ObjectId.Parse("65f5b9f121161c9c129a69fe");
            var value = await _featureService.TGetByIdAsync(id);
            var result = _mapper.Map<ResultFeatureDto>(value);

            return View(result);
        }

        
    }
}
