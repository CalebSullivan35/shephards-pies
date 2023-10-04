
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShephardsPies.Data;
using ShephardsPies.Models;

[ApiController]
[Route("api/[controller]")]

public class ToppingController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public ToppingController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  [Authorize] // comment out so post man can access.

  public IActionResult Get()
  {
    return Ok(_dbContext.Toppings);
  }

  [HttpPost("{pizzaId}/assignTopping")]

  public IActionResult assignTopping(int pizzaId, int toppingId)
  {
    Topping foundTopping = _dbContext.Toppings.SingleOrDefault(t => t.Id == toppingId);
    Pizza foundPizza = _dbContext.Pizzas.SingleOrDefault(p => p.Id == pizzaId);
    if (foundTopping == null || foundPizza == null)
    {
      return NotFound();
    }

    PizzaTopping pizzaToppingToAdd = new PizzaTopping()
    {
      ToppingId = toppingId,
      PizzaId = pizzaId
    };

    _dbContext.PizzaToppings.Add(pizzaToppingToAdd);
    _dbContext.SaveChanges();
    return NoContent();
    
  }

  [HttpPost("{pizzaId}/unassignTopping")]
  public IActionResult unassingTopping(int pizzaId, int toppingId)
  {
    PizzaTopping foundPizzaTopping = _dbContext.PizzaToppings.SingleOrDefault(pt => pt.PizzaId == pizzaId && pt.ToppingId == toppingId);

    if (foundPizzaTopping == null)
    {
      return NotFound();
    }

    _dbContext.PizzaToppings.Remove(foundPizzaTopping);
    _dbContext.SaveChanges();
    return NoContent();
    
  }
};