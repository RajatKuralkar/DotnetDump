namespace Models;
  [Serializable]

public class Employees{
    public int Id{get; set;}
    public string Name{get;set;}
    public int NoOfHrsWorked{get; set;}
    public double DA{get; set;}
    public double BasicSal{get; set;}
    public int Tax{get; set;}
    public string Dept{get; set;}
    public EmpType EType {get; set;}
    public  DateTime JoiningDate{get;set;}

    public Employees(int Id, string Name, int NoOfHrsWorked, double  DA, double BasicSal, int Tax, string Dept, EmpType EType )
    {
        this.Id=Id;
        this.Name=Name;
        this.NoOfHrsWorked=NoOfHrsWorked;
        this.DA = DA;
        this.BasicSal= BasicSal;
        this.Tax= Tax;
        this.Dept=Dept;
        this.EType=EType;
    }   

    public double computeSal ()
    {
        double finalSal;
        int T = this.Tax /100;
        finalSal = this.BasicSal + (this.NoOfHrsWorked * this.DA) -T;
        return finalSal;

    }

    public override string ToString()
    {
        return this.Id + " " + this.Name + "  " + this.NoOfHrsWorked + " " + this.DA + " " + this.BasicSal + " " + this.Tax + " " + this.Dept + " " + this.EType + " ";
    }

}
