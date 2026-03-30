using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        // Static list acting as fake database
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee { Empno = 1, Ename = "Keerthi", Job = "Developer", Salary = 50000, Deptno = 10 },
            new Employee { Empno = 2, Ename = "Ravi", Job = "Tester", Salary = 40000, Deptno = 20 },
            new Employee { Empno = 3, Ename = "Anu", Job = "Manager", Salary = 60000, Deptno = 30 }
        };

        public IActionResult Index()
        {

            return View(employees);
        }

        public IActionResult Details(int id)
        {
            Employee empObj = employees.FirstOrDefault(item => item.Empno == id);
            return View(empObj);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if(user.UserName == "admin" && user.Password == "123")
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();

        }



        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                employees.Add(obj);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid data. Some of the validations are failed.";
                return View();
            }



        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee empObj = employees.FirstOrDefault(item => item.Empno == id);
            return View(empObj);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            var existEmp = employees.FirstOrDefault(x => x.Empno == emp.Empno);

            //  employees.Remove(existEmp);
            //  employees.Add(emp);

            existEmp.Ename = emp.Ename;
            existEmp.Salary = emp.Salary;
            existEmp.Job = emp.Job;
            existEmp.Deptno = emp.Deptno;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee empObj = employees.FirstOrDefault(item => item.Empno == id);
            return View(empObj);
        }

        [HttpPost]
        [ActionName("Delete")]      //  Mapping Delete Request to DeleteConfirm Action Method
        public IActionResult DeleteConfirm(int id)
        {
            Employee empObj = employees.FirstOrDefault(item => item.Empno == id);
            employees.Remove(empObj);

            return RedirectToAction("Index");
        }

        //  parameter name should be same as query string key name
        public IActionResult Search(string job, int deptno)
        {

            var searchResultList = employees.Select(item => item);

            if (job != null)
            {
                searchResultList = searchResultList.Where(x => x.Job == job);
            }

            if (deptno != 0)
            {
                searchResultList = searchResultList.Where(x => x.Deptno == deptno);

            }

            return View(searchResultList.ToList());
        }

    }
}