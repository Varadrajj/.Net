using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person p1 = new Person { Id = 1, FirstName = "Varadraj", LastName = "Jagdale" };
        Person p2 = new Person { Id = 2, FirstName = "Arjun", LastName = "Jagtap" };
        List<Person> plist = new List<Person>();
        plist.Add(p1);
        plist.Add(p2);
        this.ViewData["Family"]=plist;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
