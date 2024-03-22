using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Counter;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public CounterController(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _counterService.TGetListAsync();
            var counterList = _mapper.Map<List<ResultCounterDto>>(values);

            return View(counterList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _counterService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCounterDto createCounterDto)
        {
            var newCounter = _mapper.Map<Counter>(createCounterDto);
            await _counterService.TCreateAsync(newCounter);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _counterService.TGetByIdAsync(id);
            var updateCounter = _mapper.Map<UpdateCounterDto>(value);
            return View(updateCounter);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCounterDto updateCounterDto)
        {
            var counter = _mapper.Map<Counter>(updateCounterDto);
            await _counterService.TUpdateAsync(counter);
            return RedirectToAction("Index");
        }
    }
}
