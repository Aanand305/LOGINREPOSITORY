using LOGINREPOSITORY.Repository;
using LOGINREPOSITORY.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LOGINREPOSITORY.Controllers
{
    public class AccountController : Controller
    {
        private IStudent studentservice;
        public AccountController(IStudent student)
        {
            this.studentservice = student; 
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(SignInModel model)
        {
            var result = studentservice.SignIn(model);

            return RedirectToAction("Index", "Home");


        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(SignUpModel model)
        {
            studentservice.SignUp(model);

            return RedirectToAction("Index");

        }
    }
}
