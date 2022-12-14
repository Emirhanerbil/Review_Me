using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
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
    }
}
