using WebApiApp.Data;
using WebApiApp.Models;
using WebApiApp.Service;
using System.Collections.Generic;
using System.Linq;

namespace WebApiApp.Service

{
    public class UserService:IUserService
    {
    
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users_.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users_.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User userViewModel)
        {
            var user = new User
            {
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Email = userViewModel.Email,
                Password = userViewModel.Password
            };

            _context.Users_.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User userViewModel)
        {
            var user = _context.Users_.FirstOrDefault(u => u.Id == userViewModel.Id);

            if (user != null)
            {
                user.FirstName = userViewModel.FirstName;
                user.LastName = userViewModel.LastName;
                user.Email = userViewModel.Email;
                user.Password = userViewModel.Password;

                _context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users_.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                _context.Users_.Remove(user);
                _context.SaveChanges();
            }
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}

