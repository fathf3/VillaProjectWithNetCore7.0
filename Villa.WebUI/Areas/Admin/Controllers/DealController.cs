﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Deal;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DealController : Controller
    {
        private readonly IDealService _dealService;
        private readonly IMapper _mapper;

        public DealController(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _dealService.TGetListAsync();
            var dealList = _mapper.Map<List<ResultDealDto>>(values);

            return View(dealList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _dealService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateDealDto createDealDto)
        {
            if (ModelState.IsValid)
            {
                var newDeal = _mapper.Map<Deal>(createDealDto);
                await _dealService.TCreateAsync(newDeal);
                return RedirectToAction("Index");
            }
            return View(createDealDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _dealService.TGetByIdAsync(id);
            var updateDeal = _mapper.Map<UpdateDealDto>(value);
            return View(updateDeal);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDealDto updateDealDto)
        {
            if (ModelState.IsValid)
            {
                var deal = _mapper.Map<Deal>(updateDealDto);
                await _dealService.TUpdateAsync(deal);
                return RedirectToAction("Index");
            }
            return View(updateDealDto);
        }

    }
}