using WebApiApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApiApp.Data;

namespace WebApiApp.Repository
{
    

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users_.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users_.FindAsync(id);
        }

        public async Task Add(User user)
        {
            await _dbContext.Users_.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            _dbContext.Users_.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _dbContext.Users_.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
    }

}
