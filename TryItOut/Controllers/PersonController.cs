using System.Web.Mvc;
using TryItOut.Controllers.BaseControllers;
using TryItOut.ViewModels;
using TryItOut.Helpers.Filters;
using TryItOut.ToDoTasks.ViewModels;
using TryItOut.Logic;

namespace TryItOut.Controllers
{
    [HandleError]
    [Footer]
    public class PersonController : BaseController
    {
        // GET: Person
        public ActionResult Index()
        {
            var person = new PersonViewModel();

            RegisteredUsersService service = new RegisteredUsersService();
            service.Save();

            //var  users = service.Read();

            service.Update();

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
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frmcollection)
        {

            if (ModelState.IsValid)
            {
                var name = frmcollection["Name"].ToString();

                return View("home");
            }

            return View();
        }

    }
}