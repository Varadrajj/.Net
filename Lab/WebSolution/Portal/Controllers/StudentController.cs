using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Collections.Generic;
namespace StudentControllers;
using services;
using model;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogueManager mgr = new CatalogueManager();
        List<Student> students = mgr.getStudents();
        ViewData["allStudents"] = students;
        return View();
    }
}
