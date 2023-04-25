using WebApiApp.Models;

namespace WebApiApp.Service
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task Add(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}
