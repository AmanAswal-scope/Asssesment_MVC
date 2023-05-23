/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;



namespace AssessmentUser.Controllers
{
    public class LoginPagesController : Controller
    {
        private readonly UDbContext _context;



        public LoginPagesController(UDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]

        public IActionResult Login(LoginPage model)
        {

            ViewBag.value=model.username.ToString();
            ViewBag.pass=model.password.ToString();
            
            // TODO: Implement your authentication logic here
            // You can check the entered username and password against your user data or authentication provider



            // Example authentication logic

            if (model.username == "admin" && model.password == "password")
            {
                // Authentication successful, redirect to the appropriate page
                return RedirectToAction("Create", "Users"); // Replace "Home" with the desired controller and action
            }
         else   if (model.username == "value" && model.password == "pass")
            {
                // Authentication successful, redirect to the appropriate page
                return RedirectToAction("Details", "Courses"); // Replace "Home" with the desired controller and action
            }
            else 
            {
                // Authentication failed, display an error message
                ModelState.AddModelError("", "Invalid username or password");
            }




            // If we reach this point, something went wrong, redisplay the login form
            return View(model);
        }

    }
}*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;



namespace AssessmentUser.Controllers
{
    public class LoginPagesController : Controller
    {
        private readonly UDbContext _context;



        public LoginPagesController(UDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]



        public IActionResult Login(LoginPage model)
        {



            ViewBag.Value = model.username.ToString();
            ViewBag.Password = model.password.ToString();
            string name = ViewBag.Value;



            User user = _context.Users.FirstOrDefault(x => x.UName == name);



            if (model.username == name && model.password == user.Password)
            {
                if (user.Role == UserRole.Admin)
                    return RedirectToAction("", "Users");
                else if (user.Role == UserRole.Employee)
                    return RedirectToAction("", "Batches");
            }
            else
            {



                ModelState.AddModelError("", "Invalid username or password");
            }





            return View(model);
        }
    }
}