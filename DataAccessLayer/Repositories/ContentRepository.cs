using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
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
            var ctx = new Context();
            var list = ctx.Contents.FromSql($"Select * from Contents").ToList();
            return list;
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
