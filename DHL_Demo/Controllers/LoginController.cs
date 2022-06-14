using Microsoft.AspNetCore.Mvc;

namespace DHL_Demo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DHL_Demo.Models.User model)
        {
            if(model.username == "admin" && model.password == "password")
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("", "User details are incorrect");
                return View(model);
            }
        }
    }
}
