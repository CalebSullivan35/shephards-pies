
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShephardsPies.Data;

[ApiController]
[Route("api/[controller]")]

public class PizzaController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public PizzaController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  // [Authorize] // comment out so post man can access.

  public IActionResult Get()
  {
    return Ok(
      _dbContext.Pizzas
      .Include(p => p.PizzaSize)
      .Include(p => p.Cheese)
      .Include(p => p.Sauce)
      .Include(p => p.PizzaToppings)
      .ThenInclude(pt => pt.Topping)
    );
  }
}