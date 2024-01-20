using Models;
using ORM;

namespace Service;

public class EmpServiceImpl : EmpService
{

    private readonly EmpDbContext empDbContext;
    public EmpServiceImpl(EmpDbContext empDbContext){
        
    }
    public void AddEmp(Employee emp)
    {
        empDbContext.Employee.Add(emp);
        empDbContext.SaveChanges();
    }

    public void DelEmp(int id)
    {
         Employee? emp=empDbContext.Employee.Find(id);
        empDbContext.Employee.Remove(emp);
        empDbContext.SaveChanges();
    }

    public List<Employee> GetAll()
    {
        List<Employee> empList = new List<Employee>();
        //empList=empDBRepo.GetAll();
        //empList=disEmpRepo.GetAll();
        return empDbContext.Employee.ToList();
    }

    public Employee GetById(int id)
    {
        return empDbContext.Employee.Find(id);
    }

    public void UpdateEmp(int id, Employee emp)
    {
        throw new NotImplementedException();
    }

    // public void UpdateEmp(int id, Employee emp)
    // {
    //     throw new NotImplementedException();
    // }

    public void UpdateEmp(int id,Employee employee){
        Console.WriteLine("---->",employee);
        Employee? emp=empDbContext.Employee.Find(employee.Id);
        emp.Name=employee.Name;
        
        emp.empType=employee.EType;
        emp.JoiningDate=employee.JoiningDate;
        Console.WriteLine(emp);
        empDbContext.SaveChanges();
    }
}



