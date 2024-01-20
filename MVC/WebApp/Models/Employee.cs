using System.ComponentModel.DataAnnotations;

namespace Models;
[Serializable]
public class Employee
{
    
    [Required(ErrorMessage ="Id is  required")]
     public int Id{ get; set; }
    [Required(ErrorMessage ="Name is Required")]
    public string? Name { get; set;}
    
    public EmpType empType{get;set;}
    [Required(ErrorMessage ="Date of joining cant be empty")]
    public DateTime JoiningDate{ get; set; }

    public Employee(){}
    public Employee(int Id, string Name,EmpType empType,DateTime JoiningDate)
    {
        this.Id = Id;
        this.Name = Name;
        this.empType = empType;
        this.JoiningDate=JoiningDate;
    }

    public override string ToString()
    {
        return this.Id + " " +this.Name+ " " +this.empType+ " " +this.JoiningDate+ " ";

    }
}