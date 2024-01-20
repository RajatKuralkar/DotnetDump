using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;
using WebApp.Models;


namespace Controllers;

public class EmpController : Controller
{
    private readonly EmpService empService;
    public EmpController(EmpService empService)
    {
        this.empService = empService;
    }

    public IActionResult Index()
    {
        List<Employee> empList = empService.GetAll();
        ViewData["employees"] = empList;
        return View();
    }

    [HttpGet]
    public IActionResult AddEmp()
    {
        
        return View();

    }

    [HttpPost]
    public IActionResult CreateEmp(int Id, string Name,EmpType empType,DateTime JoiningDate)
    {
        if(ModelState.IsValid)
        {
            Employee e = new Employee( Id,  Name,(EmpType)empType,JoiningDate);
            empService.AddEmp(e);
            return RedirectToAction("Index","Emp",null);

        }
        return View ("AddEmp");
        
    }

   [HttpGet]
   public IActionResult UpdateForm(int Id)
   {
    List<Employee>empList = empService.GetAll();
    var emp = empList.Find((e) => e.Id == Id);
    return View (emp);
   }

//    [HttpPost]
//    public IActionResult UpdateEmp(int Id, string Name,EmpType empType,DateTime JoiningDate)
//    {

//    }
}
