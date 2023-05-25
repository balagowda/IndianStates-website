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

        [HttpPost]
        public IActionResult ViewDetails(string pic, string place, string desc)
        {
            var obj = new Visit
            {
                visitId = 10,
                visitPic = pic,
                visitDesc = desc,
                visitPlace = place,
            };

            return View(obj);
        }
    }
}

                   /* <a href="@Url.Action("ViewDetails", "Visit", new {pic = v.visitPic,place = v.visitPlace, desc = v.visitDesc })" class="btn btn-primary col-12">More</a>
*/
