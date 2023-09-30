
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShephardsPies.Data;
using ShephardsPies.Models;

[ApiController]
[Route("api/[controller]")]

public class OrderController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public OrderController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  // [Authorize] // comment out so post man can access.

  public IActionResult Get()
  {
    return Ok(_dbContext.Orders
   .Include(o => o.Pizzas)
    .ThenInclude(p => p.PizzaToppings)
    .Include(o => o.Pizzas)
    .ThenInclude(p => p.PizzaSize)
    .Include(o => o.EmployeeReciever)
    .Include(o=> o.DeliveryDriver)
    .OrderByDescending(o => o.TimePlaced));
   
  }

  [HttpGet("{id}")]
  [Authorize]

  public IActionResult getOrderDetail(int id)
  {
    return Ok(_dbContext.Orders.Include(o => o.Pizzas)
    .ThenInclude(p => p.PizzaToppings)
    .Include(o => o.Pizzas)
    .ThenInclude(p => p.PizzaSize)
    .Include(o => o.Pizzas)
    .ThenInclude(p => p.Sauce)
    .Include(o => o.Pizzas)
    .ThenInclude(p => p.Cheese)
    .Include(o => o.Pizzas)
    .ThenInclude(p => p.PizzaToppings)
    .ThenInclude(pt => pt.Topping)
    .Include(o => o.EmployeeReciever)
    .Include(o=> o.DeliveryDriver)
    .SingleOrDefault(o => o.Id == id));
  }
}