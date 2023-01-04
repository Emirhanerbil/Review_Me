using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Review_Me.ViewComponents.Review
{
    public class ReviewListBySeller : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ContentManager cm = new ContentManager(new EFContentRepository());
            var values = cm.GetContents(id);
            return View(values);
        }
    }
}
