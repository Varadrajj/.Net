using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThirdWebApp.Models;
using Catalogue;
namespace ThirdWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Product p = new Product();
        p.Title = "Rose";
        p.Description = "Valentine Flower";
        p.UnitPrice = 20;
        p.Quantity = 10;
        p.ImgUrl = ".\\images\\rose.jpg";

        ViewData["flower"] = p;
        return View();
    }



}
