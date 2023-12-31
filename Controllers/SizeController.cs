
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShephardsPies.Data;

[ApiController]
[Route("api/[controller]")]

public class SizeController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public SizeController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  // [Authorize] // comment out so post man can access.

  public IActionResult Get()
  {
    return Ok(_dbContext.PizzaSizes);
  }
}