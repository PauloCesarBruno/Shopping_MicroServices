using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProducViewtModel>> FindAllProducts(string? token);
        Task<ProducViewtModel> FindProductById(long id, string? token);
        Task<ProducViewtModel> CreateProduct(ProducViewtModel model, string? token);
        Task<ProducViewtModel> UpdateProduct(ProducViewtModel model, string? token);
        Task<bool> DeleteProductById(long id, string? token);
    }
}
