using System.Diagnostics;
using Catalogue;
using Microsoft.AspNetCore.Mvc;
using Third1WebApp.Models;

namespace Third1WebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        Product p1 = new Product();

        p1.id = 1;
        p1.Title = "Red Rose";
        p1.Description = "Valentine Flower";
        p1.UnitPrice = 23;
        p1.Quantity = 500;
        p1.ImageUrl = "/Images/ValentineRose.jpg";

        ViewData["Flower"] = p1;
        return View();
    }


}