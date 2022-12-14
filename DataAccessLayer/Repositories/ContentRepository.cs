using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ContentRepository : IContentDal
    {
        Context c = new Context();
        public void Delete(Content item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public List<Content> GetAll()
        {
            return c.Contents.ToList();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();


        }

        public void Insert(Content item)
        {
            c.Add(item);
            c.SaveChanges();

        }

        public void Update(Content item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
