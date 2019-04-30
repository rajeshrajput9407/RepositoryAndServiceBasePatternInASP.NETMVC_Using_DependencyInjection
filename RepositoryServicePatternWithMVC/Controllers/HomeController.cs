using Repository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryServicePatternWithMVC.Controllers
{
    public class HomeController : Controller
    {
        private IStudentService _studentService;
        public HomeController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        public ActionResult Index()
        {
            int result = _studentService.totalStudent();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
