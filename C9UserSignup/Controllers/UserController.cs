using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C9UserSignup.Models;
using C9UserSignup.ViewModels;

namespace C9UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = UserData.GetAll();

            return View(users);
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);

        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if(ModelState.IsValid)
            {
                UserData.Add(addUserViewModel.CreateUser(addUserViewModel));

                return Redirect("/User");
            }

            return View(addUserViewModel);
        }

        public IActionResult Detail(int userId)
        {
            ViewBag.user = UserData.GetById(userId);

            return View();
        }

    }
}
