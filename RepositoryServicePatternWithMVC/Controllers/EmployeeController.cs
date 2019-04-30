using Models;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryServicePatternWithMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IStudentService _studentService;
        public EmployeeController(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<Test> allEmployee = _studentService.GetEmployees();
            return View(allEmployee);
        }
    }
}