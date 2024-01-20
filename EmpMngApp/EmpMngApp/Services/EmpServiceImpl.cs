namespace Services;
using System.Collections.Generic;
using Models;
using Repo;
using CustomExceptions;

public class EmpServiceImpl: EmployeeServices{
    EmpRepo empRepo= new EmpRepo();
    string filename ="..\\EmpFile\\EmpData.json";
    public List<Employees>GetAll()
    {
        List<Employees>empList =  new List<Employees>();
        empList = empRepo.DeSerialize(filename);
        return empList;

    }

    public void AddEmp(List<Employees>empList)
    {
        empRepo.Serialize(empList,filename);
    }
    
    public Employees GetById(int id){
        List<Employees> emps = empRepo.DeSerialize(filename);

        foreach(Employees emp in emps){
            if(emp.Id == id){
                return emp;
            }
        }
        throw new ResourceNotFoundException("Employee does not exist with the given id !!!! ");
    }

    public void DelEmp(int id){
        List<Employees> emps = empRepo.DeSerialize(filename);
        foreach(Employees emp in emps){
            if(emp.Id == id){
                emps.Remove(emp);
                break;
            }
        }
        empRepo.Serialize(emps,filename);
    }

    public void UpdateEmp(int id,Employees newEmp)
    {
        Employees emp = GetById(id);
        emp.Id=newEmp.Id;
        emp.Name=newEmp.Name;
        emp.Dept=newEmp.Dept;
        emp.NoOfHrsWorked=newEmp.NoOfHrsWorked;
        emp.JoiningDate=newEmp.JoiningDate;
        emp.EType=newEmp.EType;
        emp.BasicSal=newEmp.BasicSal;
        emp.Tax=newEmp.Tax;
        emp.DA=newEmp.DA;
        DelEmp(id);
        List<Employees> empList = GetAll();
        empList.Add(emp);
        AddEmp(empList);
    }

}

