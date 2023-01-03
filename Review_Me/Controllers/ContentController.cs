using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntitiyFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Review_Me.Models;

namespace Review_Me.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentRepository());
        Context context = new Context();
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetContents()
        {
            ContentSellerUser su = new ContentSellerUser();
            //var content = cm.GetContents();
            //return View(content);
            su.Sellers = context.Sellers.ToList();
            su.Users = context.Users.ToList();
            su.Contents = context.Contents.ToList();
            su.Jobs = context.Jobs.ToList();
            return View(su);

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
        
        public IActionResult Search(string searchTerm)
        {
            ContentSellerUser su = new ContentSellerUser();
            var searchResults = cm.GetContentByName(searchTerm);
            su.Sellers = context.Sellers.ToList();
            su.Users = context.Users.ToList();
            su.Contents = context.Contents.ToList();
            su.Jobs = context.Jobs.ToList();
            return View(su);

        }
        public IActionResult Remove(int id)
        {
            var value = cm.GetContentByID(id);
            cm.ContentRemove(value);
            return RedirectToAction(nameof(GetContents));
        }

        public IActionResult GetContentsJobs()
        {
            ContentSellerUser su = new ContentSellerUser();

            su.Sellers = context.Sellers.ToList();
            su.Users = context.Users.ToList();
            su.Contents = context.Contents.ToList();
            su.Jobs = context.Jobs.ToList();
            return View(su);
        }


        public IActionResult Update(int id)
        {
            
            var value = cm.GetContentByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Content content)
        {
            
            cm.ContentUpdate(content);
            return RedirectToAction(nameof(GetContents));
        }


        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Profile(int id)
        {
            //ContentSellerUser su = new ContentSellerUser();

            //su.Sellers = context.Sellers.ToList();
            //su.Users = context.Users.ToList();
            //su.Contents = context.Contents.ToList();
            //su.Jobs = context.Jobs.ToList();
            //return View(su);

            var value = cm.GetContentByID(id);
            return View(value);
        }


    }
}
