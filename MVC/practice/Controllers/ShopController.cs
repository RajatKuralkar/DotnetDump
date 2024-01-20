using System.Diagnostics;
using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using practice.Models;

namespace practice.Controllers;

public class ShopController : Controller
{
    
    private AppDbContext _db;

    public ShopController(AppDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Shop> shopList = _db.Shops.ToList();
        return View(shopList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
