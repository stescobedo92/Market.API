using System.Threading.Tasks;
using Market.API.Domain.Models;
using Market.API.Domain.Models.Queries;
using Market.API.Domain.Services.Communication;

namespace Market.API.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}