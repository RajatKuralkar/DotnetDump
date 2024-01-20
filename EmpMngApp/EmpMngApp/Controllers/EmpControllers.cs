using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace EmpMngApp.Controllers;

public class EmpControllers : Controller
{
    private readonly EmployeeServices employeeServices;
    public EmpControllers(EmployeeServices employeeServices)
    {
        this.employeeServices=employeeServices;

    }

    public  IActionResult Index()
    {
        List<Employees> empList=employeeServices.GetAll();
        ViewData["employee"]= empList;
        return View();

    }

    [HttpGet]

    public IActionResult AddEmp(){
        return View();
    }

    [HttpPost]

    public IActionResult UpdateEmp(int Id,String Name,int noHrs,double BasicSal,int Tax,string Dept,double DA, int EType,DateTime JoiningDate)
    {
        Console.WriteLine("--->",Id);

        Console.WriteLine("--->",Name);
        Employees e = employeeServices.GetById(Id);
        Console.WriteLine(e);
        e.Name = Name;
        e.NoOfHrsWorked = noHrs;
        e.BasicSal = BasicSal;
        e.Tax = Tax;
        e.Dept = Dept;
        e.DA = e.DA;
        e.EType=(EmpType)EType;
        e.JoiningDate = JoiningDate;
        employeeServices.UpdateEmp(Id,e);
        return RedirectToAction("Index","Emp",null);


    }

    [HttpGet]
    public IActionResult DelEmp(int Id){
        employeeServices.DelEmp(Id);
        return RedirectToAction("Index","Emp",null);


    }


    public IActionResult Privacy()
    {
        return View();
    }
}