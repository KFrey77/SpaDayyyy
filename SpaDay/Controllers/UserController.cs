using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route ("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser.Username;
                return View("Index");
            }
            else
            {
                return View("Add");
            }
            

           /* EventData.Add(newEvent);

            return Redirect("/Events");*/
        }

    }
    //two parameters
}
