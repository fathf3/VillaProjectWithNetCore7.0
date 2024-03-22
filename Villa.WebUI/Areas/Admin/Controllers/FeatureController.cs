using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Feature;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _featureService.TGetListAsync();
            var featureList = _mapper.Map<List<ResultFeatureDto>>(values);

            return View(featureList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _featureService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto createFeatureDto)
        {
            if (ModelState.IsValid)
            {
                var newFeature = _mapper.Map<Feature>(createFeatureDto);
                await _featureService.TCreateAsync(newFeature);
                return RedirectToAction("Index");
            }
            return View(createFeatureDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _featureService.TGetByIdAsync(id);
            var updateFeature = _mapper.Map<UpdateFeatureDto>(value);
            return View(updateFeature);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateFeatureDto updateFeatureDto)
        {
            if (ModelState.IsValid)
            {
                var feature = _mapper.Map<Feature>(updateFeatureDto);
                await _featureService.TUpdateAsync(feature);
                return RedirectToAction("Index");
            }
            return View(updateFeatureDto);
        }

    }
}
