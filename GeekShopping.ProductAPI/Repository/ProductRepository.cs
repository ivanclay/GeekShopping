using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository;

public class ProductRepository : IProductRepository
{
    private readonly MySqlContext _context;
    private readonly IMapper _mapper;

    public ProductRepository(MySqlContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductVO>> FindAll()
    {
        List<Product> products = await _context.Products.ToListAsync();
        return _mapper.Map<IEnumerable<ProductVO>>(products);
    }

    public async Task<ProductVO> FindById(long id)
    {
        var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<ProductVO>(product);
    }

    public async Task<ProductVO> Create(ProductVO vo)
    {
        Product product = _mapper.Map<Product>(vo);
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductVO>(product);
    }

    public async Task<ProductVO> Update(ProductVO vo)
    {
        Product product = _mapper.Map<Product>(vo);
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductVO>(product);
    }

    public async Task<bool> Delete(long id)
    {
        try
        {
            var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (product == null) return false;   
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {

            return false;
        }
    }

}
