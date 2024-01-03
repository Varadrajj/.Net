using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCRUD.Models;
using DAL.Connected;
using MVCRUD.Models;
namespace MVCRUD.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        List<Product> products=DBManager.getAllProducts();
        ViewData["products"]=products;
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id, string name, int qty,double price)
    {
        Product p = new Product(id, name, qty, price);
        DBManager.Insert(p);
        if(p!= null && ModelState.IsValid){
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
    public IActionResult Delete(int Pid)
    {
        DBManager.Delete(Pid);
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
    public IActionResult Update(int id, string name, int qty,double price)
    {
        Product product=new Product(id,name,qty,price);
        DBManager.Update(product);
        if(product != null && ModelState.IsValid){
            return RedirectToAction("List");
        }
        else
        return View();
    }

}
