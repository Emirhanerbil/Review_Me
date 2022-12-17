using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Review_Me.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetContents()
        {
            var content = cm.GetContents();
            return View(content);
        }

        public IActionResult AddContent()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddContent(Content content)
        {
            cm.ContentAdd(content);
            return RedirectToAction(nameof(GetContents));

        }
    }
}
