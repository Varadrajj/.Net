using System.Diagnostics;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }


    public IActionResult Dashboard()
    {
        return View();
    }

    public IActionResult Index()
    {
        List<Employee> employees = HRDBManager.getAllEmployees();
        ViewData["employees"] = employees;
        return View();
    }

    public IActionResult List()
    {
        List<Employee> employees = HRDBManager.getAllEmployees();
        return View(employees);

    }

    public IActionResult Details(int id)
    {
        List<Employee> employees = HRDBManager.getAllEmployees();
        var e = employees.Find((emp) => emp.Id == id);
        return View(e);
    }

    public IActionResult Edit(int id)
    {
        List<Employee> employees = HRDBManager.getAllEmployees();
        var e = employees.Find((emp) => emp.Id == id);
        return View(e);
    }

    [HttpPost]
    public IActionResult Edit(Employee emp)
    {
        Console.WriteLine(emp.Id + " " + emp.Name);
        if (emp != null && ModelState.IsValid)
        {
            return RedirectToAction("List");
        }
        else
            return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
