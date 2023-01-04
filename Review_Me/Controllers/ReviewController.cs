 using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Review_Me.Controllers
{
    public class ReviewController : Controller
    {
        ContentManager sm = new ContentManager(new EFContentRepository());
        SellerManager cm = new SellerManager(new EFSellerRepository());
        public IActionResult Index()
        {
            var value = cm.GetSellerWithJob();

            return View(value);
            
        }
        public PartialViewResult PartialReview(int id)
        {
            var values = sm.GetContents(id);
            return PartialView(values);
        }

        public IActionResult AddReview()
        {
            
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddReview(Content content)
        {
            content.SellerID = 1;
            content.UserID = 1;
            sm.ContentAdd(content);
            return RedirectToAction(nameof(Index));
        }


    }
}
