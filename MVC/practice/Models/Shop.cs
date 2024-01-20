using System.ComponentModel.DataAnnotations;

namespace Models;
public class Shop{
    public string? Pname{get; set;}
    [Key]
    public int Pid{get; set;}
    public double Pprice{get;set;}

}