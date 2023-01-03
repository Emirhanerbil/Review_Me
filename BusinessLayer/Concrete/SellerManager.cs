using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SellerManager : ISellerService
    {
        ISellerDal sellerDal;



        public SellerManager(ISellerDal sellerDal)
        {
            this.sellerDal=sellerDal;
        }

        public List<Seller> GetSeller()
        {
            return sellerDal.GetAll();
        }

        public Seller GetSellerByID(int id)
        {
            return sellerDal.GetById(id);
        }

        public List<Seller> GetSellerByName(string seller)
        {
            throw new NotImplementedException();
        }

        public void SellerAdd(Seller seller)
        {
            sellerDal.Insert(seller);
        }

        public void SellerRemove(Seller seller)
        {
            sellerDal.Delete(seller);
        }

        public void SellerUpdate(Seller seller)
        {

            sellerDal.Update(seller);
        }
    }
}
