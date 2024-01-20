using ORM;
using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<EmpDbContext>(_=>new EmpDbContext(builder.Configuration));
builder.Services.AddScoped<EmpService,EmpServiceImpl>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// dotnet new sln 
// dotnet new mvc -o appname
// dotnet sln add ./ path to csproj
// dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
// dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
// dotnet Build
// dotnet run
