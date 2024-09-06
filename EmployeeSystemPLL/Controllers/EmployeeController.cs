using EmployeeSystem.BLL.ModelVM.EmployeeVM;
using EmployeeSystem.BLL.Service.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.PLL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IDepartmentService departmentService;
        public EmployeeController(IEmployeeService employeeService , IDepartmentService departmentservice) 
        {
            this.employeeService = employeeService;
            this.departmentService = departmentservice;
        }
        public ActionResult Index()
        {
            var Result = employeeService.GetAll();
            return View(Result);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Departments = departmentService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateEmployeeVM createEmployeeVM)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (employeeService.Create(createEmployeeVM))
                    {
                        return RedirectToAction("Index" , "Employee");
                    }
                    return View(createEmployeeVM);
                }
                return View(createEmployeeVM);
            }
            catch
            {
                return View(createEmployeeVM);
            }
        }
        public ActionResult Edit()
        {
            ViewBag.Departments = departmentService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(CreateEmployeeVM createEmployeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (employeeService.Create(createEmployeeVM))
                    {
                        return RedirectToAction("Index", "Employee");
                    }
                    return View(createEmployeeVM);
                }
                return View(createEmployeeVM);
            }
            catch
            {
                return View(createEmployeeVM);
            }
        }
    }
}
