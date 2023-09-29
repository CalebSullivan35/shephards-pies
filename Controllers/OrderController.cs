
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShephardsPies.Data;

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
    return Ok(_dbContext.Orders);
  }
}