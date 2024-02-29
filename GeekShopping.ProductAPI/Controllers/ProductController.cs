using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers;

[Route("api/v1/[controller]")]
public class ProductController : Controller
{
    private IProductRepository _productRepository;
    public ProductController(IProductRepository repository)
    {
        _productRepository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductVO>> FindById(long id)
    {
        var product = await _productRepository.FindById(id);
        if (product == null) return NotFound();

        return Ok(product);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
    {
        var products = await _productRepository.FindAll();
        if (products == null) return NotFound();
        return Ok(products);
    }
}
