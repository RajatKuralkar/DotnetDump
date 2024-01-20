namespace Services;
using Models;

public interface EmployeeServices{
    public List<Employees>GetAll();

    public Employees GetById(int id);
    public void AddEmp(List<Employees> emp);
    public void DelEmp(int id);
    public void UpdateEmp(int id,Employees emp);
}