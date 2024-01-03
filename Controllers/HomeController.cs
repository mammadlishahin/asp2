

using Microsoft.AspNetCore.Mvc;

namespace Yeni.Controllers{
    public class HomeController:Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult About(){
            return View();
        }

    }
}