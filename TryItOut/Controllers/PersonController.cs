using System.Web.Mvc;
using TryItOut.Controllers.BaseControllers;
using TryItOut.ViewModels;
using TryItOut.Helpers.Filters;
using TryItOut.ToDoTasks.ViewModels;
using TryItOut.Logic;
using TryItOut.CommonInterfaces;
using TryItOut.Service;

namespace TryItOut.Controllers
{
    [HandleError]
    [Footer]
    public class PersonController : BaseController
    {
        private readonly ILogin_Service loginService = null;

        public PersonController(ILogin_Service loginService)
        {
            this.loginService = loginService;
        }

        public ActionResult Index()
        {
            var person = new PersonViewModel();

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection frmcollection)
        {
            var vmConfirmation = new ConfirmationViewModel();

            if (ModelState.IsValid)
            {
                var name = frmcollection["Name"].ToString();

                return View("Confirmation", vmConfirmation);
            }

            return View();
        }

        public ActionResult PersonCancel() {

            return Redirect("~/home");
        }

        public ActionResult Login()
        {
            LoginViewModel viewModel = new LoginViewModel();

            return View("Login", viewModel);
        }

        [HttpPost]
        public ActionResult Login(FormCollection frmcollection)
        {
            LoginViewModel viewModel = new LoginViewModel();

            if (ModelState.IsValid)
            {
                var userName = frmcollection["UserName"].ToString();
                var password = frmcollection["password"].ToString();

                /* need dto model for return login success and status */
                var userLogin = loginService.LoginUser(userName, password);

                if (userLogin.IsLoggedIn)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    /* mapper required */
                    viewModel.Message = userLogin.Message;
                }
            }

            return View("Login", viewModel);
        }

    }
}