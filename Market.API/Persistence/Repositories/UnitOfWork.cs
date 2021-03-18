using System.Threading.Tasks;
using Market.API.Domain.Repositories;
using Market.API.Persistence.Contexts;

namespace Market.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        } 
    }
}