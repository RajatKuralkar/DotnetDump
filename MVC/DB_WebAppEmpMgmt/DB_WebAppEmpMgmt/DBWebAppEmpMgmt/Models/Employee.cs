using System.ComponentModel.DataAnnotations;
namespace Models;
[Serializable]
public class Employee
{
    [Required(ErrorMessage ="Id is Required!")]
    public int Id { get; set; }
    [Required(ErrorMessage="Name is Required!")]
    public string Name { get; set; }
    [Required(ErrorMessage="NoOfHrsWorked is Required!")]
    public int NoOfHrsWorked { get; set; }
    [Required(ErrorMessage ="DA is Required!")]
    public double DA { get; set; }
    [Required(ErrorMessage ="Basic salary is Required!")]
    public double BasicSal { get; set; }
    [Required(ErrorMessage ="Tax can't be empty !")]
    public int Tax { get; set; }
    [Required(ErrorMessage ="Department can't be empty!")]
    public string Dept { get; set; }
    [Required(ErrorMessage ="Employee type can't be empty!")]
    [Range(0,3)]
    public EmpType EType { get; set; }
    [Required(ErrorMessage ="Date of Joining can't be empty!")]
    public DateTime JoiningDate { get; set; }

    public Employee(){}

    public Employee(int Id, string Name, int NoOfHrsWorked, double BasicSal, int Tax, string Dept, double DA, EmpType EType, DateTime JoiningDate)
    {
        this.Id = Id;
        this.Name = Name;
        this.NoOfHrsWorked = NoOfHrsWorked;
        this.BasicSal = BasicSal;
        this.Tax = Tax;
        this.Dept = Dept;
        this.DA = DA;
        this.EType = EType;
        this.JoiningDate = JoiningDate;
    }
    public double computeSal()
    {
        double finalSal;
        int T = this.Tax / 100;
        finalSal = this.BasicSal + (this.NoOfHrsWorked * this.DA) - T;
        return finalSal;
    }
    public override string ToString()
    {
        return this.Id + " " + this.Name + " " + this.EType + " " + this.NoOfHrsWorked + " " + this.BasicSal + " " + this.JoiningDate + " " + this.Tax + " " + this.Dept;
    }
}