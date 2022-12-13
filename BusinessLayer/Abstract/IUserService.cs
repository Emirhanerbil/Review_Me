using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void UserAdd(User user);
        void UserRemove(User user);
        User GetUserById(int id);
        List<User> GetUsers();
        void UserUpdate(User user);
    }
}
