using EmployeeSystem.BLL.ModelVM.DepartmentVM;
using EmployeeSystem.BLL.Service.Abstraction;
using EmployeeSystem.BLL.Service.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.PLL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        public ActionResult Index()
        {
            var Result = departmentService.GetAll();
            return View(Result);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GetAllDepartmentVM dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (departmentService.Create(dept))
                    {
                        return RedirectToAction("Index", "Department");
                    }
                    return View(dept);
                }
                return View(dept);
            }
            catch
            {
                return View(dept);
            }
        }
    }
}
