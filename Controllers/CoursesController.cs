using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevUniversity.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ActiveCourses()
        {
            return View();
        }
        public IActionResult MyCourses()
        {
            return View();
        }
    }
}