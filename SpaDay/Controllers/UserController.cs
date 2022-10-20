/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;*/
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.View_Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            
                return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            { 
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {

                 User user = new User
                    
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    Email = addUserViewModel.Email,
                    VerifyPassword = addUserViewModel.VerifyPassword
                };

                    return View("Index", user);
                    }
            
            else
            {
                    ViewBag.error = "Passwords do not match! Try again!";
                    return View("Add", addUserViewModel);

             }


        }
                    return View("Add", addUserViewModel);

    }

    }
}
