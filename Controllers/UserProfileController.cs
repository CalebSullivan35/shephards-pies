using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShephardsPies.Data;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase {
  private ShephardsPiesDbContext _dbContext;

  public UserController(ShephardsPiesDbContext context)
  {
    _dbContext = context;
  }

  [HttpGet]
  [Authorize]
 public IActionResult Get()
  {
    return Ok(_dbContext.UserProfiles);
  }
}



