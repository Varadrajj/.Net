using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using BLL;
using BOL;
using DAL;
namespace MVCApp.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        ServiceManager manager=new ServiceManager();
        List<Student> slist= manager.GetAllStudents();
        ViewData["students"]=slist;
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id,string fname, string lname, string contact, string city)
    {
        Student student=new Student(id,fname,lname,contact,city);
        ServiceManager manager=new ServiceManager();
        manager.Insert(student);
        if(student!=null && ModelState.IsValid){
            return RedirectToAction("List");
        }else{
            return View();
        }
        
    }
    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        ServiceManager manager=new ServiceManager();
        manager.Delete(id);
        if(ModelState.IsValid){
            return RedirectToAction("List");
        }else{
            return View();
        }
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(int id,string fname, string lname, string contact, string city)
    {
        Student student=new Student(id,fname,lname,contact,city);
        ServiceManager manager=new ServiceManager();
        manager.Update(student);
        if(student!=null && ModelState.IsValid){
            return RedirectToAction("List");
        }else{
            return View();
        }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
