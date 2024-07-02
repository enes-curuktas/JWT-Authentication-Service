using Models;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        void Register(User user);
    }
}
