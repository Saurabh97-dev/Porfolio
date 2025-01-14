using Microsoft.AspNetCore.Mvc;

namespace Saurabh_Profile.Areas.Customers.Controllers
{
    [Area("Customers")]
    public class MyselfController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
