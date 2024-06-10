using Microsoft.AspNetCore.Mvc;
using ProductQueryMS.DbContexts;

namespace ProductQueryMS.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QueryController: ControllerBase
{
    private readonly AppDbContext _context;
    
    public QueryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAllProducts()
    {
        return Ok(_context.Products.ToArray());
    }
}