using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcRepositoryPattern.Models;
using mvcRepositoryPattern.ViewModel;

namespace mvcRepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {

            _employeeRepository = employeeRepository;

        }

        public ActionResult Index()
        {
            IEnumerable<Employee> model =_employeeRepository.GetAllEmployees();
            return View(model);

        }

        public ViewResult Details()
        {
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(2),
                PageTitle = "Employee Details"
            };
            return View(employeeDetailsViewModel);
        }

    }
}