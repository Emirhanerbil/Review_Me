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
    public class SellerRepository : ISellerDal
    {
        Context c = new Context();
        public void Delete(Seller item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public List<Seller> GetAll()
        {
            var ctx = new Context();
            var list = ctx.Sellers.FromSql($"Select * from Sellers").ToList();
            return list;
        }

        public Seller GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Seller item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public List<Seller> SearchName(string name)
        {
            var ctx = new Context();
            var list = ctx.Sellers.FromSql($"select * from Contents where  Seller.SellerName like ({"%name%"})   ").ToList();
            return list;
        }

        public void Update(Seller item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
