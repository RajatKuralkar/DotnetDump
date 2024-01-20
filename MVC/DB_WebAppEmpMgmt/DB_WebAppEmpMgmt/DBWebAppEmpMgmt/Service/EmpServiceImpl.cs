namespace Service;
using ORM;
using System.Collections.Generic;
using Models;
// using Repo.ConnectedDataAccess;
// using Repo.DisConnectedDataAccess;
using CustomExceptions;

public class EmpServiceImpl : EmpService
{
    // EmpDBRepo empDBRepo=new EmpDBRepo();
    // DisconnectedEmpDBRepo disEmpRepo=new DisconnectedEmpDBRepo();
    private readonly EmpDbContext empDbContext;
    public EmpServiceImpl(EmpDbContext empDbContext){
        this.empDbContext=empDbContext;
    }
    public List<Employee> GetAll()
    {
        
        List<Employee> empList = new List<Employee>();
        //empList=empDBRepo.GetAll();
        //empList=disEmpRepo.GetAll();
        return empDbContext.Employee.ToList();
    }

    public void AddEmp(Employee emp){
        //empDBRepo.AddEmp(emp);
        //disEmpRepo.AddEmp(emp);
        empDbContext.Employee.Add(emp);
        empDbContext.SaveChanges();
    }

    public Employee GetById(int id){
       // return empDBRepo.GetById(id);
       //return disEmpRepo.GetById(id);
       return empDbContext.Employee.Find(id);
    }
    public void DelEmp(int id){
        //empDBRepo.DelEmp(id);
        //disEmpRepo.DelEmp(id);
        Employee? emp=empDbContext.Employee.Find(id);
        empDbContext.Employee.Remove(emp);
        empDbContext.SaveChanges();
    }
    public void UpdateEmp(int id,Employee employee){
        Console.WriteLine("---->",employee);
        Employee? emp=empDbContext.Employee.Find(employee.Id);
        emp.Name=employee.Name;
        emp.Dept=employee.Dept;
        emp.NoOfHrsWorked=employee.NoOfHrsWorked;
        emp.BasicSal=employee.BasicSal;
        emp.DA=employee.DA;
        emp.Tax=employee.Tax;
        emp.EType=employee.EType;
        emp.JoiningDate=employee.JoiningDate;
        Console.WriteLine(emp);
        empDbContext.SaveChanges();
    }
}