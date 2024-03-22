using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Video;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _videoService.TGetListAsync();
            var videoList = _mapper.Map<List<ResultVideoDto>>(values);

            return View(videoList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _videoService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateVideoDto createVideoDto)
        {
            if (ModelState.IsValid)
            {
                var newVideo = _mapper.Map<Video>(createVideoDto);
                await _videoService.TCreateAsync(newVideo);
                return RedirectToAction("Index");
            }
            return View(createVideoDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _videoService.TGetByIdAsync(id);
            var updateVideo = _mapper.Map<UpdateVideoDto>(value);
            return View(updateVideo);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateVideoDto updateVideoDto)
        {
            if (ModelState.IsValid)
            {
                var video = _mapper.Map<Video>(updateVideoDto);
                await _videoService.TUpdateAsync(video);
                return RedirectToAction("Index");
            }
            return View(updateVideoDto);
        }

    }
}
