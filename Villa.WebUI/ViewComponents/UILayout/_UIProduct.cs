using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstracts;
using Villa.Dto.Dtos.Product;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIProduct : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _UIProduct(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productList = await _productService.TGetListAsync();
            var result = _mapper.Map<List<ResultProductDto>>(productList);
            return View(result);
        }
    }
}
