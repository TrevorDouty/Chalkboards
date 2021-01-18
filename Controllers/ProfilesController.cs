using System.Collections.Generic;
using System.Threading.Tasks;
using chalkboards.Models;
using chalkboards.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace chalkboards.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ProfilesController : ControllerBase
  {
    private readonly ProfilesService _ps;
    private readonly BoardsService _bs;





    [HttpGet]
    [Authorize]
    public async Task<ActionResult<Profile>> Get()
    {
      try
      {
        Profile userInfo = await HttpContext.GetUserInfoAsync<Profile>();
        return Ok(_ps.GetorCreate(userInfo));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]

    public ActionResult<Profile> GetActionResult(string id)
    {
      try
      {
        return Ok(_ps.GetOne(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}