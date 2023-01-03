using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EFSellerRepository : GenericRepository<Seller>, ISellerDal
    {
        public List<Seller> GetListWithJob()
        {
            using(var c = new Context())
            {
                return c.Sellers.Include(x =>x.Job).ToList();
            }

        }
    }
}
