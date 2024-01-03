using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using Catalogue;
namespace MyApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact(){
        return View();
    }

    public IActionResult AboutUs(){
        return View();
    }

    public IActionResult ProductList(){

        Product p=new Product();
        p.Id=1;
        p.Title="Rose";
        p.Description="Valentine Flower";
        p.UnitPrice=20;
        p.Quantity=30;
        p.ImgUrl=".\images\Rose.jpg"

        ViewData["flower"]=p;
        return View();

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
