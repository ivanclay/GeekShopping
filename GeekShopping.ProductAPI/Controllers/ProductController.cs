using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
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
        if (product.Id <= 0) return NotFound();

        return Ok(product);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
    {
        var products = await _productRepository.FindAll();
        if (products == null) return NotFound();
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult<ProductVO>> Create(ProductVO vo) 
    {
        if (vo == null) return BadRequest();
        var productVo = await _productRepository.Create(vo);
        return Ok(productVo);
    }

    [HttpPut]
    public async Task<ActionResult<ProductVO>> Update(ProductVO vo)
    {
        if (vo == null) return BadRequest();
        var productVo = await _productRepository.Update(vo);
        return Ok(productVo);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(long id)
    {
        var status = await _productRepository.Delete(id);
        if (!status) return BadRequest();
        return Ok(status);
    }
}
