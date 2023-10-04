
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShephardsPies.Data;

[ApiController]
[Route("api/[controller]")]

public class PizzaToppingController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public PizzaToppingController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  [Authorize] // comment out so post man can access.

  public IActionResult Get()
  {
    return Ok(_dbContext.PizzaToppings);
  }

  [HttpGet("{id}")]
  [Authorize]

  public IActionResult getMatchingToppings(int id)
  {
    var results = _dbContext.PizzaToppings.Include(pt => pt.Topping).Where(pt => pt.PizzaId == id);

    if (results == null)
    {
      return NotFound();
    }

    return Ok(results);
  }
  



}