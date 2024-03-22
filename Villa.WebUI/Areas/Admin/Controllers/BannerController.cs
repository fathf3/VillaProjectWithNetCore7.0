using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Banner;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
   
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public BannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerList = _mapper.Map<List<ResultBannerDto>>(values);

            return View(bannerList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _bannerService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createBannerDto)
        {
            if (ModelState.IsValid)
            {
                var newBanner = _mapper.Map<Banner>(createBannerDto);
                await _bannerService.TCreateAsync(newBanner);
                return RedirectToAction("Index");
            }
            return View(createBannerDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            var updateBanner = _mapper.Map<UpdateBannerDto>(value);
            return View(updateBanner);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto updateBannerDto)
        {
            if (ModelState.IsValid)
            {
                var banner = _mapper.Map<Banner>(updateBannerDto);
                await _bannerService.TUpdateAsync(banner);
                return RedirectToAction("Index");
            }
            return View(updateBannerDto);
        }

    }
}
