using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Product;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.TGetListAsync();
            var productList = _mapper.Map<List<ResultProductDto>>(values);

            return View(productList);
        }

        public async Task<IActionResult> Delete(ObjectId id)
        {
            await _productService.TDeleteAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            if (ModelState.IsValid)
            {
                var newProduct = _mapper.Map<Product>(createProductDto);
                await _productService.TCreateAsync(newProduct);
                return RedirectToAction("Index");
            }
            return View(createProductDto);
        }

        [HttpGet]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var value = await _productService.TGetByIdAsync(id);
            var updateProduct = _mapper.Map<UpdateProductDto>(value);
            return View(updateProduct);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductDto updateProductDto)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(updateProductDto);
                await _productService.TUpdateAsync(product);
                return RedirectToAction("Index");
            }
            return View(updateProductDto);
        }

    }
}
