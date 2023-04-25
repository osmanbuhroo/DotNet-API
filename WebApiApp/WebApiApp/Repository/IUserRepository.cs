using WebApiApp.Models;

namespace WebApiApp.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task Add(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}
