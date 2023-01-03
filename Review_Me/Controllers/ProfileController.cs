using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Review_Me.Models;

namespace Review_Me.Controllers
{
    public class ProfileController : Controller
    {
        SellerManager sm = new SellerManager(new EFSellerRepository());
        Context context = new Context();
        public IActionResult Index()
        {
            ContentSellerUser su = new ContentSellerUser();
            su.Sellers = context.Sellers.ToList();
            su.Users = context.Users.ToList();
            su.Contents = context.Contents.ToList();
            su.Jobs = context.Jobs.ToList();

            return View(su);
        }

        public IActionResult ProfilPage(int id)
        {
            var value = sm.GetSellerByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult ProfilPage(Seller seller)
        {
            ContentSellerUser su = new ContentSellerUser();
            sm.SellerUpdate(seller);
            su.seller2 = context.Sellers.ToList()[0];


            return View(su);
        }
    }
}
