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
    public Task<ProductVO> Create(ProductVO vo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(long id)
    {
        throw new NotImplementedException();
    }



    public async Task<ProductVO> FindById(long id)
    {
        var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<ProductVO>(product);
    }

    public Task<ProductVO> Update(ProductVO vo)
    {
        throw new NotImplementedException();
    }
}
