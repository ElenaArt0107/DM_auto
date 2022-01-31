using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_in_class.Controllers
{
    public class BrowerController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is an index page for Brower Controller");
        }

        public IActionResult ReturnBrower(int id)
        {
            var brower = new
            {
                id,
                naam = "Morgat"
            };
            return Json(brower);
        }

        public IActionResult ReturnBrowerSoort(int soortid)
        {
            var brower = new
            {
                id = 1,
                soortid,
                naam = "Morgat"
            };
            return Json(brower);
        }

        public IActionResult ExampleQueryString(int soortid, string naam, bool alcocholfree)
        {
            var brower = new
            {
                id = 1,
                soortid,
                alcocholfree,
                naam,

            };
            return Json(brower);
        }
    }
}
