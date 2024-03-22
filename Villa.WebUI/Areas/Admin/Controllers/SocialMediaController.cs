using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.SocialMedia;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _socialMediaService.TGetListAsync();
            var socialMediaList = _mapper.Map<List<ResultSocialMediaDto>>(values);

            return View(socialMediaList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _socialMediaService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialMediaDto createSocialMediaDto)
        {
            if (ModelState.IsValid)
            {
                var newSocialMedia = _mapper.Map<SocialMedia>(createSocialMediaDto);
                await _socialMediaService.TCreateAsync(newSocialMedia);
                return RedirectToAction("Index");
            }
            return View(createSocialMediaDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _socialMediaService.TGetByIdAsync(id);
            var updateSocialMedia = _mapper.Map<UpdateSocialMediaDto>(value);
            return View(updateSocialMedia);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            if (ModelState.IsValid)
            {
                var socialMedia = _mapper.Map<SocialMedia>(updateSocialMediaDto);
                await _socialMediaService.TUpdateAsync(socialMedia);
                return RedirectToAction("Index");
            }
            return View(updateSocialMediaDto);
        }

    }
}
