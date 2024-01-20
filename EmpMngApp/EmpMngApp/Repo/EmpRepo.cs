using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Repo;

public class EmpRepo
{
  public void Serialize(List<Employees>empList,String fileName)
  {
     var options = new JsonSerializerOptions { IncludeFields = true };
        var employeesJson = JsonSerializer.Serialize<List<Employees>>(empList, options);
        File.WriteAllText(fileName, employeesJson);
  }

  public  List<Employees>DeSerialize(string fileName)
  {
    string jsonString = File.ReadAllText(fileName);
    List<Employees> jsonEmployees = JsonSerializer.Deserialize<List<Employees>>(jsonString);
    return jsonEmployees;

  }
}