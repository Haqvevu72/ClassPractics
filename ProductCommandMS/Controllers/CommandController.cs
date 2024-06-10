using Microsoft.AspNetCore.Mvc;
using ProductCommandMS.DbContexts;
using ProductCommandMS.Model;

namespace ProductCommandMS.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommandController: ControllerBase
{
    private readonly AppDbContext _context;


    public CommandController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("AddProduct")]
    public IActionResult Add(Product p)
    {
        _context.Products.Add(p);

        return Ok();
    }

    [HttpDelete("DeleteProduct")]
    public IActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            _context.Products.Remove(product);
            return Ok();
        }

        return NotFound();
    }

    [HttpPut("UpdateProduct")]
    public IActionResult Update(int id, Product p)
    {
        // Vaxt catmadi 
        return Ok();
    }
}