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
        ContentManager cm = new ContentManager(new EFContentRepository());
        SellerManager sm = new SellerManager(new EFSellerRepository());
        Context context = new Context();
        public IActionResult Index()
        {
            var value = sm.GetSellerWithJob();

            return View(value);
        }

        public IActionResult ProfilPage(int id)
        {
            ViewBag.i = id;    
            var value = sm.GetSellerID(id);

            return View(value);
        }
        public IActionResult AddReview()
        {

            return PartialView();
        }
        [HttpPost]
        public IActionResult AddReview(Content content)
        {
            
            content.UserID = 1;
            cm.ContentAdd(content);
            return RedirectToAction(nameof(Index));
        }

    }
}
