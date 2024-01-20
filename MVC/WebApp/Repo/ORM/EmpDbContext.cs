namespace ORM;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models;

public class EmpDbContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public EmpDbContext(IConfiguration configuration)
    {
        Configuration = configuration;

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = Configuration.GetConnectionString("MyDatabase");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    public DbSet<Employee> Employee{get; set;}
}

// 



