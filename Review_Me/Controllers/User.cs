using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Review_Me.Controllers
{
    public class User : Controller
    {
        UserManager um = new UserManager(new EFUserRepository());
        public IActionResult Index()
        {
            var values = um.GetUsers();
            return View(values);
        }
    }
}
