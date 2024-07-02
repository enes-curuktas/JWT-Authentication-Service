using Business.Abstract;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>();

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.UserName == username && x.Password == password);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Register(User user)
        {
            _users.Add(user);
        }
    }
}
