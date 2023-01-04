using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISellerService
    {
        void SellerAdd(Seller seller);
        void SellerRemove(Seller seller);
        Seller GetSellerByID(int id);
        List<Seller> GetSeller();
        void SellerUpdate(Seller seller);
        List<Seller> GetSellerByName(string seller);

        List<Seller> GetSellerWithJob();


       
    }
}
