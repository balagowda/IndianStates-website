using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class VisitController : Controller
    {
        public IActionResult Index()
        {
           visitAccess access = new visitAccess();
            var Visit = access.GetStates();
            return View(Visit);
        }
    }
}
