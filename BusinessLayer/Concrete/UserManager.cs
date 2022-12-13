using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;

        

        public UserManager(IUserDal userDal)
        {
            this.userDal=userDal;
        }

        public User GetUserById(int id)
        {
            return userDal.GetById(id);
        }

        public List<User> GetUsers()
        {
            return userDal.GetAll();
        }

        public void UserAdd(User user)
        {
            userDal.Insert(user);
            
        }

        public void UserRemove(User user)
        {
            userDal.Delete(user);
        }

        public void UserUpdate(User user)
        {
            userDal.Update(user);
        }
    }
}
