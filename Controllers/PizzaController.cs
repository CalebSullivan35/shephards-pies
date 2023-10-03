
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShephardsPies.Data;
using ShephardsPies.Models;

[ApiController]
[Route("api/[controller]")]

public class PizzaController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public PizzaController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  [Authorize] // comment out so post man can access.

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

  //post a new pizza
  [HttpPost]
  [Authorize]
  public IActionResult CreatePizza(Pizza pizza)
  {
    _dbContext.Pizzas.Add(pizza);
    _dbContext.SaveChanges();
    return Created($"/api/pizza/{pizza.Id}", pizza);
  }


  //delete a pizza
  [HttpDelete("{id}")]
  [Authorize]
  public IActionResult DeletePizza(int id)
  {
    Pizza PizzaToRemove = _dbContext.Pizzas.SingleOrDefault(p => p.Id == id);
    _dbContext.Pizzas.Remove(PizzaToRemove);
    _dbContext.SaveChanges();
    return NoContent();
  }
}