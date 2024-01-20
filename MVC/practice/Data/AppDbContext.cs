using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Models;

namespace Data;
public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Shop> Shops{get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // module builder
        modelBuilder.Entity<Shop>().HasData(
            new Shop(){Pid=101, Pname="Rajat Shop-1", Pprice=29999.99},
            new Shop(){Pid=102, Pname="Rajat Shop-2", Pprice=29999.99},
            new Shop(){Pid=103, Pname="Rajat Shop-3", Pprice=29999.99},
            new Shop(){Pid=104, Pname="Rajat Shop-4", Pprice=29999.99},
            new Shop(){Pid=105, Pname="Rajat Shop-5", Pprice=29999.99}
            
        );
    }

}
