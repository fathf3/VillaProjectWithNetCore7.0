using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Question;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _questionService.TGetListAsync();
            var questionList = _mapper.Map<List<ResultQuestionDto>>(values);

            return View(questionList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _questionService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionDto createQuestionDto)
        {
            if (ModelState.IsValid)
            {
                var newQuestion = _mapper.Map<Question>(createQuestionDto);
                await _questionService.TCreateAsync(newQuestion);
                return RedirectToAction("Index");
            }
            return View(createQuestionDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _questionService.TGetByIdAsync(id);
            var updateQuestion = _mapper.Map<UpdateQuestionDto>(value);
            return View(updateQuestion);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateQuestionDto updateQuestionDto)
        {
            if (ModelState.IsValid)
            {
                var question = _mapper.Map<Question>(updateQuestionDto);
                await _questionService.TUpdateAsync(question);
                return RedirectToAction("Index");
            }
            return View(updateQuestionDto);
        }

    }
}
