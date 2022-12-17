using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IUserDal
    {
        Context c = new Context();
        public void AddUser(User user)
        {
            c.Add(user);
            c.SaveChanges();
        }

        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return c.Users.Find(id);
        }

        public void Insert(User item)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            c.Remove(user);
            c.SaveChanges();
        }

        public List<User> SearchName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
           c.Update(user);
           c.SaveChanges();
        }

        public List<User> UsersGetList()
        {
            return c.Users.ToList();
        }
    }
}
