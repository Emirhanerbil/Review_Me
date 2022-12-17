using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();

        public void Delete(T item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public List<T> SearchName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
