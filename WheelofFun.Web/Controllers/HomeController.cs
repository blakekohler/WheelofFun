using System.Web.Mvc;

namespace WheelofFun.Web.Controllers
{
    public class HomeController : WheelofFunControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}