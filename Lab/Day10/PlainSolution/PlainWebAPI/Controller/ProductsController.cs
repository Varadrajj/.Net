using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
namespace ReactWithWebAPIApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        Cataloguemanager mgr = new Cataloguemanager();
        List<Product> products = mgr.GetAllProducts();
        return products.ToArray();
    }

    // [HttpGet("{pid}")]
    // public Product GetById(int pid)
    // {

    // }
}
