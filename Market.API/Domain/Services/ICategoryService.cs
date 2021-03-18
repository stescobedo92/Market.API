using System.Collections.Generic;
using System.Threading.Tasks;
using Market.API.Domain.Models;
using Market.API.Domain.Services.Communication;

namespace Market.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}