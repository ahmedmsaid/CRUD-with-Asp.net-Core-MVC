using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class EmployeeController : Controller
    {
        MyDbContext DB = new MyDbContext();
        public IActionResult Index()
        { 
            List<Employee> emp = DB.Employees.ToList();
            return View(emp);
        }

        public IActionResult details(int id)
        {
            Employee emp = DB.Employees.SingleOrDefault(e => e.SSN == id);
            return View(emp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            DB.Employees.Add(emp);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Employee emp = DB.Employees.SingleOrDefault(e => e.SSN == id);
            if (emp == null)
            {
                return Content("Error");
            }

            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            Employee oldEmp = DB.Employees.SingleOrDefault(e => e.SSN == emp.SSN);
            if (emp == null)
            {
                return Content("Error");
            }

            oldEmp.Name = emp.Name;
            oldEmp.Address = emp.Address;
            oldEmp.Age = emp.Age;

            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Employee emp = DB.Employees.SingleOrDefault(e => e.SSN == id);

            if (emp == null)
            {
                return Content("Error");
            }

            DB.Employees.Remove(emp);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
