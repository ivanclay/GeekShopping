using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _client;
    public const string BASE_PATH = "api/v1/product";

    public ProductService(HttpClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public async Task<IEnumerable<ProductModel>> FindAllProducts()
    {
        var response = await _client.GetAsync(BASE_PATH);
        return await response.ReadContentAsync<List<ProductModel>>();
    }

    public async Task<ProductModel> FindProductById(long id)
    {
        var response = await _client.GetAsync($"{BASE_PATH}/{id}");
        return await response.ReadContentAsync<ProductModel>();
    }

    public async Task<ProductModel> CreateProduct(ProductModel model)
    {
        var response = await _client.PostAsJson(BASE_PATH, model);
        if (response.IsSuccessStatusCode) return await response.ReadContentAsync<ProductModel>();
        else throw new Exception("Something went wrong calling API");
    }

    public async Task<ProductModel> UpdateProduct(ProductModel model)
    {
        var response = await _client.PutAsJson(BASE_PATH, model);
        if (response.IsSuccessStatusCode) return await response.ReadContentAsync<ProductModel>();
        else throw new Exception("Something went wrong calling API");
    }

    public async Task<bool> DeleteProductById(long id)
    {
        var response = await _client.DeleteAsync($"{BASE_PATH}/{id}");
        if (response.IsSuccessStatusCode) return await response.ReadContentAsync<bool>();
        else throw new Exception("Something went wrong calling API");
    }


}
